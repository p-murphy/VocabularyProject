using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November16th
{
    // This class is mutable. Its data can be modified from 
    // outside the class.
    public class Collection
    {
        public int CollectionID { get; set; }                   // Unique ID # that corresponds to a collection of Items.
        public string CollectionPicFileName { get; set; }       // Holds address of Item's image in app assets.
        public List<Item> CollectionList { get; set; }          // A list of Items. Always either 8 or 9 entries long once instantiated.

        // A Collection is the data and conceptual frame that corresponds to the visual Polaroid
        // A Collection's image is referenced by building an absolute URI of the format:
        // ms-appx:///Images/PicabularyDemo/CollectionPicFileName.jpg

        public Levels lvl { get; set; }                         // Enum holding the strength of the collection. Used in scheduling algorithms.
        public ReviewStatus status { get; set; }                // Enum holding the status of the collection. Used in scheduling algorithms.

        public Collection(int collectionID, string collectionPicFileName, List<Item> collectionList)
        {
            CollectionID = collectionID;
            CollectionPicFileName = collectionPicFileName;
            CollectionList = collectionList;
            lvl = Levels.Introductory;
            status = ReviewStatus.OptionalReview;
        }
    }
}
