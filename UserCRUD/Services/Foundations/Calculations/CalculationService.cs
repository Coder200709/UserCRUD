using System.Linq;
using System.Threading.Tasks;
using System;
using CalculationCRUD.Brokers.Storages;
using UserCRUD.Models.Calculations;

namespace UserCRUD.Services.Foundations.Calculations
{
    public class CalculationService : ICalculationsService
    {
        private readonly IStorageBroker storageBroker;

        public CalculationService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<Calculation> AddcalculationAsync(Calculation calculation) =>
            await this.storageBroker.InsertCalculationAsync(calculation);

        public async ValueTask<Calculation> ModifycalculationAsync(Calculation calculation) =>
            await this.storageBroker.UpdateCalculationAsync(calculation);

        public async ValueTask<Calculation> RemovecalculationAsync(Guid calculationId)
        {
            var calculation = await this.storageBroker.SelectCalculationByIdAsync(calculationId);

            return await this.storageBroker.DeleteCalculationAsync(calculation);
        }
        public IQueryable<Calculation> RetrieveAllcalculations() =>
            this.storageBroker.SelectAllCalculations();

        public async ValueTask<Calculation> RetrievecalculationByIdAsync(Guid calculationId) =>
            await this.storageBroker.SelectCalculationByIdAsync(calculationId);

    }
}
