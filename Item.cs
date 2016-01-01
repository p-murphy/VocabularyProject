
namespace November16th
{
    // This class is mutable. Its data can be modified from 
    // outside the class.
    public class Item
    {
        public int ItemID { get; set; }                  // Unique ID # that corresponds between an Item and the various language lists.
        public string ItemPicFileName { get; set; }      // Holds address of Item's image in app assets.
        public string ItemCol { get; set; }              // Holds the name of the containing folder of the Item's image.
        public string L2 { get; set; }

        // An Item's image is referenced by building an absolute URI of the format:
        // ms-appx:///Images/PicabularyDemo/ItemCol/ItemPicFileName.jpg

        public int TimesRight { get; set; }              // Both of these track the Item's score. 
        public int TimesWrong { get; set; }              // They are used in scheduling algorithms.

        public Levels lvl { get; set; }       // Enum holding the status of the word, which signifies its color.

        public Item(int itemId, string itemPicFileName, string itemCol, string l2)
        {
            ItemID = itemId;
            ItemPicFileName = itemPicFileName;
            ItemCol = itemCol;
            TimesRight = 0;
            TimesWrong = 0;
            lvl = Levels.Introductory;
            L2 = l2;
        }
    }
}
