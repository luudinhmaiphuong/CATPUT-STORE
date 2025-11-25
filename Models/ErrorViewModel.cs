namespace CATPUT_STORE.Models
{
    public class ViewModels
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
