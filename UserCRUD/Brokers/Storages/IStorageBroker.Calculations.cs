using System.Linq;
using System.Threading.Tasks;
using System;
using UserCRUD.Models.Calculations;
using UserCRUD.Models.Feedbacks;

namespace CalculationCRUD.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Calculation> InsertCalculationAsync(Calculation calculation);
        IQueryable<Calculation> SelectAllCalculations();
        ValueTask<Calculation> SelectCalculationByIdAsync(Guid calculationId);
        ValueTask<Calculation> UpdateCalculationAsync(Calculation calculation);
        ValueTask<Calculation> DeleteCalculationAsync(Calculation calculation);
    }
}
