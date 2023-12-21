using System.Linq;
using System.Threading.Tasks;
using System;
using CalculationCRUD.Brokers.Storages;
using UserCRUD.Models.Feedbacks;
using UserCRUD.Services.Foundations.Feedbacks;

namespace UserCRUD.Services.Foundations.Feedbacks
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IStorageBroker storageBroker;

        public FeedbackService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;
        

        public async ValueTask<Feedback> AddFeedbackAsync(Feedback feedback) =>
            await this.storageBroker.

        public async ValueTask<Feedback> ModifyFeedbackAsync(Feedback feedback) =>
            await this.storageBroker.UpdateFeedbackAsync(feedback);

        public async ValueTask<Feedback> RemoveFeedbackAsync(Guid feedbackId)
        {
            var feedback = await this.storageBroker.SelectFeedbackByIdAsync(feedbackId);

            return await this.storageBroker.DeleteFeedbackAsync(feedback);
        }
        public IQueryable<Feedback> RetrieveAllFeedbacks() =>
            this.storageBroker.SelectAllFeedbacks();

        public async ValueTask<Feedback> RetrieveFeedbackByIdAsync(Guid feedbackId) =>
            await this.storageBroker.SelectFeedbackByIdAsync(feedbackId);

    }
}
