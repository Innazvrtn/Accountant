using Core.Repository;
using System;

namespace Core.Entities
{
    public class Action
    {
        public Guid ActionId { get; set; }
        public DateTime ActionDate { get; set; }
        public ActionType ActionType { get; set; }
        public User UserAction { get; set; }
        public ActionCategory ActionCategory { get; set; }
        public string ActionComment { get; set; }
        public decimal ActionSumm { get; set; }
    }
}