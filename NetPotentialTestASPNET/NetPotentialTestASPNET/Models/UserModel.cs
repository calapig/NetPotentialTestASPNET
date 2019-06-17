using System.Collections.Generic;
using System.Web.Mvc;

namespace NetPotentialTestASPNET.Models
{
    public class UserModel
    {
        public int[] SelectedTeaIds { get; set; }
        public IEnumerable<SelectListItem> TeaList { get; set; }
    }
}