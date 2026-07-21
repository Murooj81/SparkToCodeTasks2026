namespace Task7OOP2
{
    // Room class
    internal class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public Room(int roomNumber, string roomType, double pricePerNight)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = true;
        }

        public void DisplayRoom()
        {
            string status = IsAvailable ? "Available" : "Booked";
            Console.WriteLine($"Room #{RoomNumber} | Type: {RoomType} | Price: OMR {PricePerNight:F2} | [{status}]");
        }
    }

    // Guest class
    internal class Guest
    {
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        public Guest(string guestId, string guestName, string checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = "Not Assigned";
            CheckInDate = checkInDate;
            TotalNights = totalNights;
        }

        public void DisplayGuest()
        {
            Console.WriteLine($"ID: {GuestId,-5} | Name: {GuestName,-12} | Room: {RoomNumber,-12} | Check-in: {CheckInDate,-10} | Nights: {TotalNights}");
        }

        public double CalculateTotalCost(double pricePerNight)
        {
            return TotalNights * pricePerNight;
        }
    }

    // Main Program
    internal class Program
    {
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();

        static void Main(string[] args)
        {

            rooms.Add(new Room(101, "Single", 25.00));
            rooms.Add(new Room(102, "Single", 25.00));
            rooms.Add(new Room(201, "Double", 45.00));
            rooms.Add(new Room(202, "Double", 45.00));
            rooms.Add(new Room(301, "Suite", 90.00));
            rooms.Add(new Room(302, "Suite", 120.00));

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("\n--- GRAND VISTA HOTEL MANAGEMENT SYSTEM ---");
                Console.WriteLine("1. Add New Room ");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest ");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms ");
                Console.WriteLine("5. Guest Pagination Viewer");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        //AddRoom(); 
                        break;
                    case "2":
                        // RegisterGuest(); 
                        break;
                    case "3":
                        // BookRoom();
                        break;
                    case "4":
                        // ViewAllRooms(); 
                        break;
                    case "5":
                        //ViewAllGuests();
                        break;
                    case "6":
                        // FilterRoomsMenu();
                        break;
                    case "7":
                        //ShowStatistics(); 
                        break;
                    case "8":
                        //UpdatePrice(); 
                        break;
                    case "9":
                        // SearchGuestByName(); 
                        break;
                    case "10":
                        // TypeBreakdownReport();
                        break;
                    case "11":
                        // CheckOutGuest();
                        break;
                    case "12":
                        // DeleteUnavailableRooms();
                        break;
                    case "13":
                        // ExtendStay(); 
                        break;
                    case "14":
                        // HighestRevenueBooking();
                        break;
                    case "15":
                        //  PaginateGuests();
                        break;
                    case "0":
                        loop = false; Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }

        }


        // Case 1
        static void AddRoom()
        {
            Console.Write("Enter Room Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num) || num <= 0)
            {
                Console.WriteLine("Error: Room number must be a positive integer.");
                return;
            }

            if (rooms.Any(r => r.RoomNumber == num))
            {
                Console.WriteLine("Error: Room number already exists.");
                return;
            }

            Console.Write("Enter Room Type (Single/Double/Suite): ");
            string type = Console.ReadLine();

            Console.Write("Enter Price Per Night: ");
            if (!double.TryParse(Console.ReadLine(), out double price) || price <= 0)
            {
                Console.WriteLine("Error: Price must be a positive decimal.");
                return;
            }

            rooms.Add(new Room(num, type, price));
            Console.WriteLine($"Room {num} added successfully! Total rooms: {rooms.Count}");
        }

        // Case 2
        static void RegisterGuest()
        {
            Console.Write("Enter Guest ID: ");
            string id = Console.ReadLine();
            if (guests.Any(g => g.GuestId == id))
            {
                Console.WriteLine("Error: Guest ID already exists.");
                return;
            }
            Console.Write("Enter Guest Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Check-in Date (YYYY-MM-DD): ");
            string checkInDate = Console.ReadLine();
            Console.Write("Enter Total Nights: ");
            if (!int.TryParse(Console.ReadLine(), out int nights) || nights <= 0)
            {
                Console.WriteLine("Error: Total nights must be a positive integer.");
                return;
            }
            guests.Add(new Guest(id, name, checkInDate, nights));
            Console.WriteLine($"Guest {name} registered successfully! Total guests: {guests.Count}");
        }

        // Case 3
        static void BookRoom()
        {
            Console.Write("Enter Guest ID: ");
            string gId = Console.ReadLine().ToUpper();
            Console.Write("Enter Room Number: ");
            if (!int.TryParse(Console.ReadLine(), out int rNum)) return;

            Guest guest = guests.FirstOrDefault(g => g.GuestId.ToUpper() == gId);
            Room room = rooms.FirstOrDefault(r => r.RoomNumber == rNum);

            if (guest == null || room == null)
            {
                Console.WriteLine("Error: Guest or Room not found.");
                return;
            }

            if (!room.IsAvailable)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }

            room.IsAvailable = false;
            guest.RoomNumber = room.RoomNumber.ToString();

            Console.WriteLine("\n--- Booking Confirmed ---");
            Console.WriteLine($"Guest: {guest.GuestName}");
            Console.WriteLine($"Room: #{room.RoomNumber} ({room.RoomType})");
            Console.WriteLine($"Total Bill: OMR {guest.CalculateTotalCost(room.PricePerNight):F2}");
        }

        // Case 4
        static void ViewAllRooms()
        {
            Console.WriteLine("\n--- All Rooms ---");
            foreach (var room in rooms)
            {
                room.DisplayRoom();
            }
        }

        // Case 5
        static void ViewAllGuests()
        {
            Console.WriteLine("\n--- All Guests ---");
            foreach (var guest in guests)
            {
                guest.DisplayGuest();
            }
        }

        //case 6
        static void FilterRoomsMenu()
        {
            Console.WriteLine("1) Show available rooms\n2) Filter by type\n3) Filter by max price\n4) Price statistics\n0) Back");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var avail = rooms.Where(r => r.IsAvailable).OrderBy(r => r.PricePerNight);
                    Console.WriteLine($"Found {avail.Count()} matches:");
                    foreach (var r in avail) r.DisplayRoom();
                    break;

                case "2":
                    Console.Write("Enter Type: ");
                    string type = Console.ReadLine().ToLower();
                    var byType = rooms.Where(r => r.RoomType.ToLower() == type);
                    Console.WriteLine($"Found {byType.Count()} matches:");
                    foreach (var r in byType) r.DisplayRoom();
                    break;

                case "3":
                    Console.Write("Enter Max Budget: ");
                    if (double.TryParse(Console.ReadLine(), out double max))
                    {
                        var budget = rooms.Where(r => r.IsAvailable && r.PricePerNight <= max).OrderBy(r => r.PricePerNight);
                        Console.WriteLine($"Found {budget.Count()} matches:");
                        foreach (var r in budget) r.DisplayRoom();
                    }
                    break;

                case "4":
                    if (!rooms.Any()) return;
                    Console.WriteLine($"Total: {rooms.Count()}");
                    Console.WriteLine($"Available: {rooms.Count(r => r.IsAvailable)}");
                    Console.WriteLine($"Average: OMR {rooms.Average(r => r.PricePerNight):F2}");
                    Console.WriteLine($"Min: OMR {rooms.Min(r => r.PricePerNight):F2}");
                    Console.WriteLine($"Max: OMR {rooms.Max(r => r.PricePerNight):F2}");
                    break;
            }
        }

        // Case 7
        static void ShowStatistics()
        {
            int totalRooms = rooms.Count;
            int availableRooms = rooms.Count(r => r.IsAvailable);
            int bookedRooms = totalRooms - availableRooms;
            Console.WriteLine("\n--- Room Statistics ---");
            Console.WriteLine($"Total Rooms: {totalRooms}");
            Console.WriteLine($"Available Rooms: {availableRooms}");
            Console.WriteLine($"Booked Rooms: {bookedRooms}");
        }

        // Case 8
        static void UpdatePrice()
        {
            Console.Write("Enter Room Number: ");
            if (!int.TryParse(Console.ReadLine(), out int roomNum)) return;
            Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNum);
            if (room == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }
            Console.Write($"Current Price: OMR {room.PricePerNight:F2}. Enter New Price: ");
            if (!double.TryParse(Console.ReadLine(), out double newPrice) || newPrice <= 0)
            {
                Console.WriteLine("Error: Price must be a positive decimal.");
                return;
            }
            room.PricePerNight = newPrice;
            Console.WriteLine($"Room #{room.RoomNumber} price updated to OMR {newPrice:F2}.");

        }

        // Case 9
        static void SearchGuestByName()
        {
            Console.Write("Enter Guest Name to Search: ");
            string name = Console.ReadLine().ToLower();
            var matches = guests.Where(g => g.GuestName.ToLower().Contains(name)).ToList();
            if (matches.Count == 0)
            {
                Console.WriteLine("No guests found with that name.");
                return;
            }
            Console.WriteLine($"Found {matches.Count} matches:");
            foreach (var g in matches) g.DisplayGuest();
        }

        //case 10
        static void TypeBreakdownReport()
        {
            var breakdown = rooms.GroupBy(r => r.RoomType)
                                 .Select(g => new { Type = g.Key, Count = g.Count() })
                                 .ToList();
            Console.WriteLine("\n--- Room Type Breakdown ---");
            foreach (var item in breakdown)
            {
                Console.WriteLine($"Type: {item.Type} | Count: {item.Count}");
            }
        }

        // Case 11
        static void CheckOutGuest()
        {
            Console.Write("Enter Guest ID to Check Out: ");
            string gId = Console.ReadLine().ToUpper();
            Guest guest = guests.FirstOrDefault(g => g.GuestId.ToUpper() == gId);
            if (guest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }
            Room room = rooms.FirstOrDefault(r => r.RoomNumber.ToString() == guest.RoomNumber);
            if (room != null)
            {
                room.IsAvailable = true;
                guest.RoomNumber = "Not Assigned";
                Console.WriteLine($"Guest {guest.GuestName} has checked out. Room #{room.RoomNumber} is now available.");
            }
        }

        // Case 12
        static void DeleteUnavailableRooms()
        {
            int initialCount = rooms.Count;
            rooms.RemoveAll(r => !r.IsAvailable);
            int removedCount = initialCount - rooms.Count;
            Console.WriteLine($"Removed {removedCount} unavailable rooms. Total rooms now: {rooms.Count}");

        }

        // Case 13
        static void ExtendStay()
        {
            Console.Write("Enter Guest ID to Extend Stay: ");
            string gId = Console.ReadLine().ToUpper();
            Guest guest = guests.FirstOrDefault(g => g.GuestId.ToUpper() == gId);
            if (guest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }
            Console.Write($"Current Total Nights: {guest.TotalNights}. Enter Additional Nights: ");
            if (!int.TryParse(Console.ReadLine(), out int additionalNights) || additionalNights <= 0)
            {
                Console.WriteLine("Error: Additional nights must be a positive integer.");
                return;
            }
            guest.TotalNights += additionalNights;
            Console.WriteLine($"Guest {guest.GuestName}'s stay extended. New Total Nights: {guest.TotalNights}");

        }
        // Case 14
        static void HighestRevenueBooking()
        {
            var active = guests.Where(g => g.RoomNumber != "Not Assigned");

            if (!active.Any())
            {
                Console.WriteLine("No active bookings recorded.");
                return;
            }

            var topBooking = active.OrderByDescending(g => g.CalculateTotalCost(rooms.First(r => r.RoomNumber.ToString() == g.RoomNumber).PricePerNight))
                                   .Take(1)
                                   .FirstOrDefault();

            double rate = rooms.First(r => r.RoomNumber.ToString() == topBooking.RoomNumber).PricePerNight;
            Console.WriteLine($"Highest Revenue Booking: {topBooking.GuestName} (Room {topBooking.RoomNumber}) - OMR {topBooking.CalculateTotalCost(rate):F2}");
        }

        // Case 15
        static void PaginateGuests()
        {
            int size = 3;
            int totalPages = (int)Math.Ceiling((double)guests.Count / size);

            Console.Write($"Enter Page Number (1 to {Math.Max(1, totalPages)}): ");
            if (!int.TryParse(Console.ReadLine(), out int page) || page <= 0) return;

            if (page > totalPages && guests.Any())
            {
                Console.WriteLine("That page does not exist.");
                return;
            }

            var items = guests.Skip((page - 1) * size).Take(size);
            Console.WriteLine($"\n--- Page {page} of {Math.Max(1, totalPages)} ---");
            foreach (var g in items)
            {
                g.DisplayGuest();
            }
        }
    }
}
