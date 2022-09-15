namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;
            System.Console.WriteLine(remainingNumberOfBirds);
            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int numOfRacoons = 3;
            int hungryRacoons = 2;
            int remainingRacoons = numOfRacoons - hungryRacoons;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int numOfFlowers = 5;
            int numOfbees = 3;
            int beesComparedToFlowers = numOfFlowers - numOfbees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int lonePigeon = 1;
            int newPigeon = 1;
            int bothPigeons = lonePigeon + newPigeon;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int firstOwls = 3;
            int newOwls = 2;
            int allOwls = firstOwls + newOwls;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int firstBeavers = 2;
            int loneBeaver = 1;
            int beaversLeft = firstBeavers - loneBeaver;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int firstToucans = 2;
            int loneToucan = 1;
            int toucansLeft = firstToucans + loneToucan;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int totSquirrels = 4;
            int totNuts = 2;
            int squirrelsComparedToNuts = totSquirrels - totNuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quarter = 0.25M;
            decimal dime = 0.10M;
            decimal nickel = 0.05M;

            decimal totMoney = quarter + dime + 2 * nickel;

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int brierTotal = 18;
            int macTotal = 20;
            int flanTotal = 17;
            int allTotal = brierTotal + macTotal + flanTotal;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyoPrice = 0.24M;
            decimal whistlePrice = 0.14M;
            decimal totSpend = yoyoPrice + whistlePrice;
            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int numOfLargeMallows = 8;
            int numOfMiniMallows = 10;
            int totMallows = numOfLargeMallows + numOfMiniMallows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltInches = 29;
            int breckNockInches = 17;
            int hiltBreckDifference = hiltInches - breckNockInches;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int hiltInit = 10;
            int truckPrice = 3;
            int pencilPrice = 2;
            double remainingMoney = hiltInit - (truckPrice + pencilPrice);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int initMarbles = 16;
            int marblesLost = 7;
            int marblesLeft = initMarbles - marblesLost;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int megSeashells = 19;
            int seashellsWanted = 25;
            int seshellsNeeded = seashellsWanted - megSeashells;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int balloonTotal = 17;
            int redBalloons = 8;
            int greenBallons = balloonTotal - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int booksintitial = 38;
            int booksAdded = 10;
            int booksTotal = booksintitial + booksAdded;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int eightBeeLegs = beeLegs * 8;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double conePrice = 0.99;
            double totalCones = conePrice * 2;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rocksNeeded = 125;
            int currentRocks = 64;
            int rocksToAdd = rocksNeeded - currentRocks;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int marblesInitial = 38;
            int lostMarbles = 15;
            int marblesRemaining = marblesInitial - lostMarbles;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int totTripMiles = 78;
            int milesDriven = 32;
            int milesLeft = totTripMiles - milesDriven;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int totMinutesSaturdayMorn = 90;
            int totMinutesSaturdayAfternoon = 45;
            int totMinutesShoveled = totMinutesSaturdayMorn + totMinutesSaturdayAfternoon;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int totHotdogs = 6;
            decimal priceOfHotdog = 0.50M;
            decimal totPriceOfHotdogs = totHotdogs * priceOfHotdog;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal totAmount = 0.50M;
            decimal pencilCost = 0.07M;
            int totPencilAffordable = (int)(totAmount / pencilCost);
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int butterfliesSeen = 33;
            int orangeButterflies = 20;
            int redButterflies = butterfliesSeen - orangeButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double initialPayment = 1.00;
            double candyPrice = 0.54;
            decimal changeGiven = (decimal)(initialPayment - candyPrice);
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int totTrees = 13;
            int moreTrees = 12;
            int treesInYard = totTrees + moreTrees;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysUntilVisit = 2;
            int hoursInDay = 24;
            int timeUntilVisit = daysUntilVisit * hoursInDay;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int totCousings = 4;
            int gumPerCousin = 5;
            int gumNeeded = totCousings * gumPerCousin;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal danTotal = 3.00M;
            decimal twixPrice = 1.00M;
            decimal moneyLeftForDan = (decimal) (danTotal - twixPrice);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boatsInLake = 5;
            int peoplePerBoat = 3;
            int peopleOnLake = boatsInLake * peoplePerBoat;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int totalLegos = 380;
            int legosGone = 57;
            int legosLeft = totalLegos - legosGone;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int muffinsBaked = 35;
            int muffinsWanted = 83;
            int muffinsNeeded = muffinsWanted - muffinsBaked;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int diffInCrayons = willyCrayons - lucyCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersOnPage = 10;
            int totalPages = 22;
            int totalStickers = stickersOnPage * totalPages;
            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            double totCupcakes = 100;
            double totChildren = 8;
            double cakePerPerson = (double) (totCupcakes / totChildren);

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */
            int totGingerCookies = 47;
            int cookiesPerJar = 6;
            int cookiesLeftover = totGingerCookies % cookiesPerJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */
            int totCroissants = 59;
            int totNeighbors = 8;
            int leftOverCroissants = totCroissants % totNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int classmateCookies = 276;
            int cookiesPerTray = 12;
            int traysNeeded = classmateCookies / cookiesPerTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totPretzels = 480;
            int servingSize = 12;
            int totPretzelsMade = totPretzels / servingSize;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCakes = 53;
            int lemonCakesLeft = 2;
            int boxesOfthree = (lemonCakes - lemonCakesLeft) / (3);
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int totCarrots = 74;
            int carrotPeople = 12;
            int uneatenCarrots = totCarrots % carrotPeople;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totTeddyBears = 98;
            int maxBearsPerShelf = 7;
            int shelvesFilled = totTeddyBears / maxBearsPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int totPictures = 480;
            int totPicturesPerAlbum = 20;
            int albumsNeeded = totPictures / totPicturesPerAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int cardsCollected = 94;
            int boxMaximum = 8;
            int cardsLeftover = cardsCollected % boxMaximum;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int bookTotal = 210;
            int shelvesTotal = 10;
            int booksPerShelf = bookTotal / shelvesTotal;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            double totalCroissants = 17;
            double totalGuests = 7;
            double guestCroissants = (double) (totalCroissants / totalGuests);
            /*
            51. Bill and Jill are house painters. Bill can paint a standard room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 standard rooms?
            Hint: Calculate the rate at which each painter can complete a room (rooms / hour), combine those rates,
            and then divide the total number of rooms to be painted by the combined rate.
            */
            decimal billRate = (decimal) (1 / 2.15);
            decimal jillRate = (decimal) (1 / 1.90);
            decimal combinedRate = billRate + jillRate;
            double fiveRoomRate = (double) (5 / combinedRate);
            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace";
            string lastName = "Hopper";
            string middleInitial = "B";

            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";


            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            int cityDistance = 800;
            int trainDistance = 537;
            double percentComplete = trainDistance / cityDistance;
            int percentAsWhole = (int)(percentComplete * 100);

        }
    }
}
