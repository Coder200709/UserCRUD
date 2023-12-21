using System;
using UserCRUD.Models.Users;

namespace UserCRUD.Models.Feedbacks
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string Answer { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
