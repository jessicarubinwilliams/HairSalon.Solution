using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }

        public int StylistId { get; set; }
        public string Name { get; set; }
        public string CellPhoneNum { get; set; }
        public string Competencies { get; set; }
        public string Specialties { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}