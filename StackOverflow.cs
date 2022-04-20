using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    public class StackOverflow
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; } = DateTime.UtcNow;
        public int VoteCount { get; private set; } = 0;

        public StackOverflow(string title, string description)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }
            Title = title;
            Description = description;
        }

        public void VoteUp()
        {
            switch (VoteCount)
            {
                case -1:
                case 0:
                    VoteCount += 1;
                    break;
            }
        }

        public void VoteDown()
        {
            switch (VoteCount)
            {
                case -1:
                case 0:
                    VoteCount -= 1;
                    break;
            }
        }

    }
}
