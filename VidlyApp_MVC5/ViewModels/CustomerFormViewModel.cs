using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyApp_MVC5.Models;

namespace VidlyApp_MVC5.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}