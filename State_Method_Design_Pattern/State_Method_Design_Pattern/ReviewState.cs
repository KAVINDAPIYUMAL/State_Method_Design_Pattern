using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Method_Design_Pattern
{
    public class ReviewState
    {
        public void Handle()
        {
            Console.WriteLine("Document is in Review state. Editing is restricted. Reviewers can provide feedback.");
        }
    }
}
