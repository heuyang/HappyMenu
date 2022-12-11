using System;

namespace HappyMenu.Entities
{
    public class PlanItem
    {

        public int PlanItemId { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; } // [ BREAKFAST | LUNCH | DINNER | SNACK ]
        public string Note { get; set; }
        public int AddedByFamilyMemberId { get; set; }
        public int ForFamilyMemberId { get; set; }
        public DateTime CreatedTime { get; set; }

        public FamilyMember AddedByFamilyMember {  get; set; }
        public FamilyMember ForFamilyMember { get; set; }
    }
}
