using System.Linq;
using System.Threading.Tasks;
using System;
using UserCRUD.Models.Calculations;

namespace UserCRUD.Services.Foundations.Calculations
{
    public interface ICalculationsService
    {
        ValueTask<Calculation> AddcalculationAsync(Calculation calculation);
        ValueTask<Calculation> RetrievecalculationByIdAsync(Guid calculationId);
        IQueryable<Calculation> RetrieveAllcalculations();
        ValueTask<Calculation> ModifycalculationAsync(Calculation calculation);
        ValueTask<Calculation> RemovecalculationAsync(Guid calculationId);
    }
}
