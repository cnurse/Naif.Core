// ReSharper disable ClassNeverInstantiated.Global
namespace Naif.Core.Models
{
    public class MenuItem : BaseMenuItem
    {
        public string Action { get; set; }
        
        public string Controller { get; set; }
        
        public bool IsActive { get; set; }
        
        public string Link { get; set; }

        public string Text { get; set; }
    }
}