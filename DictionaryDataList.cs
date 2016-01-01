using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November16th
{
    class DictionaryDataList
    {
        public Dictionary<int, string> MyDictionary { get; set; }
        public List<Item> ItemList { get; set; }

                #region Singleton Implementation
        public static DictionaryDataList instance;

        public DictionaryDataList()
        {   
            ItemList = SetupDictionary();
        }

        public static DictionaryDataList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DictionaryDataList();
                }
                return instance;
            }
        }
        #endregion

        public List<Item> SetupDictionary()
        {
            List<Item> L = new List<Item>();

            // Basement
            Item boiler = new Item(11, "Boiler", "Basement", "");
            Item box = new Item(12, "Box", "Basement", "");
            Item broom = new Item(13, "Broom", "Basement", "");
            Item chest = new Item(14, "Chest", "Basement", "");
            Item dryer = new Item(15, "Dryer", "Basement", "");
            Item flashlight = new Item(16, "Flashlight", "Basement", "");
            Item mop = new Item(17, "Mop", "Basement", "");
            Item shelf = new Item(18, "Shelf", "Basement", "");
            Item washingmachine = new Item(19, "WashingMachine", "Basement", "");
            L.Add(boiler);
            L.Add(washingmachine);
            L.Add(dryer);
            L.Add(broom);
            L.Add(mop);
            L.Add(box);
            L.Add(flashlight);
            L.Add(chest);
            L.Add(shelf);
            // Bathroom
            Item bathmat = new Item(21, "Bathmat", "Bathroom", "");
            Item bathtub = new Item(22, "Bathtub", "Bathroom", "");
            Item mirror = new Item(23, "Mirror", "Bathroom", "");
            Item shower = new Item(24, "Shower", "Bathroom", "");
            Item showercurtain = new Item(25, "ShowerCurtain", "Bathroom", "");
            Item soap = new Item(26, "Soap", "Bathroom", "");
            Item toilet = new Item(27, "Toilet", "Bathroom", "");
            Item towel = new Item(28, "Towel", "Bathroom", "");
            Item wastebasket = new Item(29, "Wastebasket", "Bathroom", "");
            L.Add(mirror);
            L.Add(shower);
            L.Add(bathtub);
            L.Add(showercurtain);
            L.Add(towel);
            L.Add(soap);
            L.Add(toilet);
            L.Add(bathmat);
            L.Add(wastebasket);
            // Bedroom
            Item alarm = new Item(31, "Alarm", "Bedroom", "");
            Item bed = new Item(32, "Bed", "Bedroom", "");
            Item carpet = new Item(33, "Carpet", "Bedroom", "");
            Item closet = new Item(34, "Closet", "Bedroom", "");
            Item curtain = new Item(35, "Curtain", "Bedroom", "");
            Item drawer = new Item(36, "Drawer", "Bedroom", "");
            Item dresser = new Item(37, "Dresser", "Bedroom", "");
            Item pillow = new Item(38, "Pillow", "Bedroom", "");
            Item sheet = new Item(39, "Sheet", "Bedroom", "");
            L.Add(bed);
            L.Add(pillow);
            L.Add(sheet);
            L.Add(curtain);
            L.Add(dresser);
            L.Add(closet);
            L.Add(alarm);
            L.Add(drawer);
            L.Add(carpet);
            // Dining Room
            Item chair = new Item(41, "Chair", "DiningRoom", "");
            Item cup = new Item(42, "Cup", "DiningRoom", "");
            Item diningtable = new Item(43, "DiningTable", "DiningRoom", "");
            Item fork = new Item(44, "Fork", "DiningRoom", "");
            Item glass = new Item(45, "Glass", "DiningRoom", "");
            Item knife = new Item(46, "Knife", "DiningRoom", "");
            Item mug = new Item(47, "Mug", "DiningRoom", "");
            Item plate = new Item(48, "Plate", "DiningRoom", "");
            Item spoon = new Item(49, "Spoon", "DiningRoom", "");
            L.Add(diningtable);
            L.Add(chair);
            L.Add(fork);
            L.Add(plate);
            L.Add(spoon);
            L.Add(knife);
            L.Add(cup);
            L.Add(glass);
            L.Add(mug);
            // Garage
            Item bicycle = new Item(51, "Bicycle", "Garage", "");
            Item car = new Item(52, "Car", "Garage", "");
            Item garagedoor = new Item(53, "GarageDoor", "Garage", "");
            Item lawnmower = new Item(54, "Lawnmower", "Garage", "");
            Item rack = new Item(55, "Rack", "Garage", "");
            Item radio = new Item(56, "Radio", "Garage", "");
            Item rake = new Item(57, "Rake", "Garage", "");
            Item toolbox = new Item(58, "Toolbox", "Garage", "");
            Item workbench = new Item(59, "Workbench", "Garage", "");
            L.Add(bicycle);
            L.Add(car);
            L.Add(garagedoor);
            L.Add(lawnmower);
            L.Add(rack);
            L.Add(radio);
            L.Add(rake);
            L.Add(toolbox);
            L.Add(workbench);
            // Kitchen
            Item cabinet = new Item(61, "Cabinet", "Kitchen", "");
            Item dishwasher = new Item(62, "Dishwasher", "Kitchen", "");
            Item drawers = new Item(63, "Drawer", "Kitchen", "");
            Item garbagecan = new Item(64, "GarbageCan", "Kitchen", "");
            Item microwave = new Item(65, "Microwave", "Kitchen", "");
            Item oven = new Item(66, "Oven", "Kitchen", "");
            Item refrigerator = new Item(67, "Refrigerator", "Kitchen", "");
            Item sink = new Item(68, "Sink", "Kitchen", "");
            Item stove = new Item(69, "Stove", "Kitchen", "");
            L.Add(cabinet);
            L.Add(dishwasher);
            L.Add(drawers);
            L.Add(garbagecan);
            L.Add(microwave);
            L.Add(oven);
            L.Add(refrigerator);
            L.Add(sink);
            L.Add(stove);
            // Living Room
            Item coffeetable = new Item(71, "CoffeeTable", "LivingRoom", "");
            Item couch = new Item(72, "Couch", "LivingRoom", "");
            Item fireplace = new Item(73, "Fireplace", "LivingRoom", "");
            Item lamp = new Item(74, "Lamp", "LivingRoom", "");
            Item picture = new Item(75, "Picture", "LivingRoom", "");
            Item rug = new Item(76, "Rug", "LivingRoom", "");
            Item stereo = new Item(77, "Stereo", "LivingRoom", "");
            Item tv = new Item(78, "TV", "LivingRoom", "");
            Item vase = new Item(79, "Vase", "LivingRoom", "");
            L.Add(coffeetable);
            L.Add(couch);
            L.Add(fireplace);
            L.Add(lamp);
            L.Add(picture);
            L.Add(rug);
            L.Add(stereo);
            L.Add(tv);
            L.Add(vase);
            // Room
            Item ceiling = new Item(81, "Ceiling", "Room", "");
            Item door = new Item(82, "Door", "Room", "");
            Item floor = new Item(83, "Floor", "Room", "");
            Item light = new Item(84, "Light", "Room", "");
            Item outlet = new Item(85, "Outlet", "Room", "");
            Item stairs = new Item(86, "Stairs", "Room", "");
            Item wall = new Item(87, "Wall", "Room", "");
            Item window = new Item(88, "Window", "Room", "");
            L.Add(ceiling);
            L.Add(door);
            L.Add(floor);
            L.Add(light);
            L.Add(outlet);
            L.Add(stairs);
            L.Add(wall);
            L.Add(window);
            // Study
            Item armchair = new Item(91, "Armchair", "Study", "");
            Item clock = new Item(92, "Clock", "Study", "");
            Item computer = new Item(93, "Computer", "Study", "");
            Item desk = new Item(94, "Desk", "Study", "");
            Item desklamp = new Item(95, "Desklamp", "Study", "");
            Item pictures = new Item(96, "Picture", "Study", "");
            Item plant = new Item(97, "Plant", "Study", "");
            Item printer = new Item(98, "Printer", "Study", "");
            L.Add(armchair);
            L.Add(clock);
            L.Add(computer);
            L.Add(desk);
            L.Add(desklamp);
            L.Add(pictures);
            L.Add(plant);
            L.Add(printer);


            return L;
        }

    }
}
