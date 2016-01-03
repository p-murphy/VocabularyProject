using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November16th
{
    public enum ReviewStatus
    {
        OptionalReview,                //Default. Can be thought of as "no status".
        SuggestedReview,               //Places a marker on the collection for Suggested Review. Used in scheduling queue.
        StruggleReview,                //Special collection of oft-failed words. Used in Scheduling queue.
        LevelTest                      //Places a marker on the collection for a Level Test. Used in scheduling queue.
    };
}
