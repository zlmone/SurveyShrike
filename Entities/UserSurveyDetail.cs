//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserSurveyDetail
    {
        public int UserSurveyDetailsId { get; set; }
        public Nullable<int> UserSurveyId { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public Nullable<int> SystemValue { get; set; }
        public string CustomValue { get; set; }
    
        public virtual Option Option { get; set; }
        public virtual Question Question { get; set; }
        public virtual UserSurvey UserSurvey { get; set; }
    }
}
