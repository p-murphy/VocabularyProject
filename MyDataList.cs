using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November16th
{



    public class MyDataList
    {
        public Dictionary<int, string> MyDictionary { get; set; }
        public List<Collection> CollectionList { get; set; }
        public string[] s9 { get; set; }
        public string[] s8 { get; set; }

        #region Singleton Implementation
        public static MyDataList instance;

        public MyDataList()
        {   
            //SetupItems();
            //SetupDictionary();

            CollectionList = SetupCollections();
            s9 = new string[9] { "", "", "", "", "", "", "", "", "" };
            s8 = new string[8] { "", "", "", "", "", "", "", ""};

        }

        public static MyDataList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MyDataList();
                }
                return instance;
            }
        }
        #endregion

        //private void SetupDictionary()
        //{
        //    MyDictionary = new Dictionary<int, string>();
        //    MyDictionary.Add(0, "Basement");
        //    MyDictionary.Add(1, "Bathroom");
        //    MyDictionary.Add(2, "Bedroom");
        //    MyDictionary.Add(3, "DiningRoom");
        //    MyDictionary.Add(4, "Garage");
        //    MyDictionary.Add(5, "Kitchen");
        //    MyDictionary.Add(6, "LivingRoom");
        //    MyDictionary.Add(7, "Room");
        //    MyDictionary.Add(8, "Study");
        //}

        public List<Collection> SetupCollections()
        {

            Item boiler = new Item(11, "Boiler", "Basement", "la caldera");
            Item box = new Item(12, "Box", "Basement", "la caja");
            Item broom = new Item(13, "Broom", "Basement", "el escoba");
            Item chest = new Item(14, "Chest", "Basement", "el arcón");
            Item dryer = new Item(15, "Dryer", "Basement", "la secadora");
            Item flashlight = new Item(16, "Flashlight", "Basement", "la linterna");
            Item mop = new Item(17, "Mop", "Basement", "el trapeador");
            Item shelf = new Item(18, "Shelf", "Basement", "el estante");
            Item washingmachine = new Item(19, "WashingMachine", "Basement", "la lavadora");

            List<Item> BasementList = new List<Item>();
            BasementList.Add(boiler);
            BasementList.Add(washingmachine);
            BasementList.Add(dryer);
            BasementList.Add(broom);
            BasementList.Add(mop);
            BasementList.Add(box);
            BasementList.Add(flashlight);
            BasementList.Add(chest);
            BasementList.Add(shelf);

            Item bathmat = new Item(21, "Bathmat", "Bathroom", "el tapete");
            Item bathtub = new Item(22, "Bathtub", "Bathroom", "la tina");
            Item mirror = new Item(23, "Mirror", "Bathroom", "el espejo");
            Item shower = new Item(24, "Shower", "Bathroom", "la regadera");
            Item showercurtain = new Item(25, "ShowerCurtain", "Bathroom", "la cortina de la regadera");
            Item soap = new Item(26, "Soap", "Bathroom", "el jabón");
            Item toilet = new Item(27, "Toilet", "Bathroom", "el excusado");
            Item towel = new Item(28, "Towel", "Bathroom", "la toalla");
            Item wastebasket = new Item(29, "Wastebasket", "Bathroom", "el bote de basura");

            List<Item> BathroomList = new List<Item>();
            BathroomList.Add(mirror);
            BathroomList.Add(shower);
            BathroomList.Add(bathtub);
            BathroomList.Add(showercurtain);
            BathroomList.Add(towel);
            BathroomList.Add(soap);
            BathroomList.Add(toilet);
            BathroomList.Add(bathmat);
            BathroomList.Add(wastebasket);

            Item alarm = new Item(31, "Alarm", "Bedroom", "el despertador");
            Item bed = new Item(32, "Bed", "Bedroom", "la cama");
            Item carpet = new Item(33, "Carpet", "Bedroom", "el tapete");
            Item closet = new Item(34, "Closet", "Bedroom", "el armario");
            Item curtain = new Item(35, "Curtain", "Bedroom", "la cortina");
            Item drawer = new Item(36, "Drawer", "Bedroom", "el cajón");
            Item dresser = new Item(37, "ChestOfDrawers", "Bedroom", "la cómoda");
            Item pillow = new Item(38, "Pillow", "Bedroom", "la almohada");
            Item sheet = new Item(39, "Sheet", "Bedroom", "la sábana");

            List<Item> BedroomList = new List<Item>();
            BedroomList.Add(bed);
            BedroomList.Add(pillow);
            BedroomList.Add(sheet);
            BedroomList.Add(curtain);
            BedroomList.Add(dresser);
            BedroomList.Add(closet);
            BedroomList.Add(alarm);
            BedroomList.Add(drawer);
            BedroomList.Add(carpet);

            Item chair = new Item(41, "Chair", "DiningRoom", "la silla");
            Item cup = new Item(42, "Cup", "DiningRoom", "la taza");
            Item diningtable = new Item(43, "DiningTable", "DiningRoom", "la mesa de comedor");
            Item fork = new Item(44, "Fork", "DiningRoom", "el tenedor");
            Item glass = new Item(45, "Glass", "DiningRoom", "el vaso");
            Item knife = new Item(46, "Knife", "DiningRoom", "el cuchillo");
            Item mug = new Item(47, "Mug", "DiningRoom", "la taza");
            Item plate = new Item(48, "Plate", "DiningRoom", "el plato");
            Item spoon = new Item(49, "Spoon", "DiningRoom", "la cuchara");

            List<Item> DiningRoomList = new List<Item>();
            DiningRoomList.Add(diningtable);
            DiningRoomList.Add(chair);
            DiningRoomList.Add(fork);
            DiningRoomList.Add(plate);
            DiningRoomList.Add(spoon);
            DiningRoomList.Add(knife);
            DiningRoomList.Add(cup);
            DiningRoomList.Add(glass);
            DiningRoomList.Add(mug);


            Item bicycle = new Item(51, "Bicycle", "Garage", "la bicicleta");
            Item car = new Item(52, "Car", "Garage", "el carro");
            Item garagedoor = new Item(53, "GarageDoor", "Garage", "la puerta de la cochera");
            Item lawnmower = new Item(54, "Lawnmower", "Garage", "la podadora");
            Item rack = new Item(55, "Rack", "Garage", "el estante");
            Item radio = new Item(56, "Radio", "Garage", "la radio");
            Item rake = new Item(57, "Rake", "Garage", "el rastrillo");
            Item toolbox = new Item(58, "Toolbox", "Garage", "la caja de herramientas");
            Item workbench = new Item(59, "Workbench", "Garage", "el banco de trabajo");

            List<Item> GarageList = new List<Item>();
            GarageList.Add(bicycle);
            GarageList.Add(car);
            GarageList.Add(garagedoor);
            GarageList.Add(lawnmower);
            GarageList.Add(rack);
            GarageList.Add(radio);
            GarageList.Add(rake);
            GarageList.Add(toolbox);
            GarageList.Add(workbench);

            Item cabinet = new Item(61, "Cabinet", "Kitchen", "la gaveta");
            Item dishwasher = new Item(62, "Dishwasher", "Kitchen", "la lavavajilla");
            Item drawers = new Item(63, "Drawer", "Kitchen", "el cajón");
            Item garbagecan = new Item(64, "GarbageCan", "Kitchen", "el bote de basura");
            Item microwave = new Item(65, "Microwave", "Kitchen", "el microondas");
            Item oven = new Item(66, "Oven", "Kitchen", "el horno");
            Item refrigerator = new Item(67, "Refrigerator", "Kitchen", "el refrigerador");
            Item sink = new Item(68, "Sink", "Kitchen", "el fregadero");
            Item stove = new Item(69, "Stove", "Kitchen", "el estufa");

            List<Item> KitchenList = new List<Item>();
            KitchenList.Add(cabinet);
            KitchenList.Add(dishwasher);
            KitchenList.Add(drawers);
            KitchenList.Add(garbagecan);
            KitchenList.Add(microwave);
            KitchenList.Add(oven);
            KitchenList.Add(refrigerator);
            KitchenList.Add(sink);
            KitchenList.Add(stove);

            Item coffeetable = new Item(71, "CoffeeTable", "LivingRoom", "la mesa de centro");
            Item couch = new Item(72, "Couch", "LivingRoom", "el sofá");
            Item fireplace = new Item(73, "Fireplace", "LivingRoom", "la chimenea");
            Item lamp = new Item(74, "Lamp", "LivingRoom", "la lámpara");
            Item picture = new Item(75, "Painting", "LivingRoom", "el cuador");
            Item rug = new Item(76, "Rug", "LivingRoom", "el tapete");
            Item stereo = new Item(77, "Stereo", "LivingRoom", "el estéreo");
            Item tv = new Item(78, "TV", "LivingRoom", "la televisión");
            Item vase = new Item(79, "Vase", "LivingRoom", "el jarrón");

            List<Item> LivingRoomList = new List<Item>();
            LivingRoomList.Add(coffeetable);
            LivingRoomList.Add(couch);
            LivingRoomList.Add(fireplace);
            LivingRoomList.Add(lamp);
            LivingRoomList.Add(picture);
            LivingRoomList.Add(rug);
            LivingRoomList.Add(stereo);
            LivingRoomList.Add(tv);
            LivingRoomList.Add(vase);


            Item ceiling = new Item(81, "Ceiling", "Room", "el techo");
            Item door = new Item(82, "Door", "Room", "la puerta");
            Item floor = new Item(83, "Floor", "Room", "el piso");
            Item light = new Item(84, "Light", "Room", "la luz");
            Item outlet = new Item(85, "Outlet", "Room", "el enchufe");
            Item stairs = new Item(86, "Stairs", "Room", "el escalera");
            Item wall = new Item(87, "Wall", "Room", "la pared");
            Item window = new Item(88, "Window", "Room", "la venta");

            List<Item> RoomList = new List<Item>();
            RoomList.Add(ceiling);
            RoomList.Add(door);
            RoomList.Add(floor);
            RoomList.Add(light);
            RoomList.Add(outlet);
            RoomList.Add(stairs);
            RoomList.Add(wall);
            RoomList.Add(window);

            Item armchair = new Item(91, "Armchair", "Study", "el sillón");
            Item clock = new Item(92, "Clock", "Study", "el reloj");
            Item computer = new Item(93, "Computer", "Study", "la computadora");
            Item desk = new Item(94, "Desk", "Study", "el escritorio");
            Item desklamp = new Item(95, "Desklamp", "Study", "la lámpara de escritorio");
            Item pictures = new Item(96, "PictureFrame", "Study", "el portarretratos");
            Item plant = new Item(97, "Plant", "Study", "la planta");
            Item printer = new Item(98, "Printer", "Study", "la impresora");

            List<Item> StudyList = new List<Item>();
            StudyList.Add(armchair);
            StudyList.Add(clock);
            StudyList.Add(computer);
            StudyList.Add(desk);
            StudyList.Add(desklamp);
            StudyList.Add(pictures);
            StudyList.Add(plant);
            StudyList.Add(printer);


            List<Item> nullList = new List<Item>();

            CollectionList = new List<Collection>();
            Collection Basement = new Collection(1, "Basement", BasementList);
            Collection Bathroom = new Collection(2, "Bathroom", BathroomList);
            Collection Bedroom = new Collection(3, "Bedroom", BedroomList);
            Collection DiningRoom = new Collection(4, "DiningRoom", DiningRoomList);
            Collection Garage = new Collection(5, "Garage", GarageList);
            Collection Kitchen = new Collection(6, "Kitchen", KitchenList);
            Collection LivingRoom = new Collection(7, "LivingRoom", LivingRoomList);
            Collection Room = new Collection(8, "Room", RoomList);
            Collection Study = new Collection(9, "Study", StudyList);

            CollectionList.Add(Basement);
            CollectionList.Add(Bathroom);
            CollectionList.Add(Bedroom);
            CollectionList.Add(DiningRoom);
            CollectionList.Add(Garage);
            CollectionList.Add(Kitchen);
            CollectionList.Add(LivingRoom);
            CollectionList.Add(Room);
            CollectionList.Add(Study);

            return CollectionList;
        }

        public void SetupItems()
        {
            //Item alarm = new Item(31, "Alarm");
            //Item bed = new Item(32, "Bed");
            //Item carpet = new Item(33, "Carpet");
            //Item closet = new Item(34, "Closet");
            //Item curtain = new Item(35, "Curtain");
            //Item drawer = new Item(36, "Drawer");
            //Item dresser = new Item(37, "Dresser");
            //Item pillow = new Item(38, "Pillow");
            //Item sheet = new Item(39, "Sheet");

            //List<Item> BedroomList = new List<Item>();
            //BedroomList.Add(alarm);
            //BedroomList.Add(bed);
            //BedroomList.Add(carpet);
            //BedroomList.Add(closet);
            //BedroomList.Add(curtain);
            //BedroomList.Add(drawer);
            //BedroomList.Add(dresser);
            //BedroomList.Add(pillow);
            //BedroomList.Add(sheet);
        }
    }
}
