using Newtonsoft.Json;

namespace dc.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Group
    {
        public int Id { get; set; }
        public bool IsHiddenInUI { get; set; }
        public string LoginName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PrincipalType { get; set; }
        public bool AllowMembersEditMembership { get; set; }
        public bool AllowRequestToJoinLeave { get; set; }
        public bool AutoAcceptRequestToJoinLeave { get; set; }
        public bool OnlyAllowMembersViewMembership { get; set; }
        public string OwnerTitle { get; set; }
        public object RequestToJoinLeaveEmailSetting { get; set; }
    }
}
