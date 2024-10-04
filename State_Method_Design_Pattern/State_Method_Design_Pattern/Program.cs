using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Method_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();

            document.Request(); // Output: Document is in Draft state. Editing is allowed.

            document.ChangeState(new ReviewState());
            document.Request(); // Output: Document is in Review state. Editing is restricted. Reviewers can provide feedback.

            document.ChangeState(new PublishedState());
            document.Request(); // Output: Document is in Published state. Editing is not allowed. It is publicly available.
        }
    }
}
