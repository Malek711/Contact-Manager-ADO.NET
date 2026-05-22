using System;

namespace Update_Data.Folder
{
    public class Program
    {
        // 1. دالة طباعة بيانات جهة الاتصال
        static void PrintContact(stcontact contact)
        {
            Console.WriteLine($"Contact ID: {contact.ContactsID}");
            Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Phone: {contact.Phone}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine($"Country ID: {contact.CountryID}");
            Console.WriteLine();
        }

        // 2. دالة إدخال الأرقام والتحقق من صحتها
        static int EnterNumberByMessage(string message)
        {
            Console.WriteLine(message + ": ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
            }
            return number;
        }

        // 3. دالة طلب البيانات الجديدة للتحديث من المستخدم
        static void UpdateFullContactInfo(ref stcontact contact)
        {
            Console.WriteLine($"\nUpdate for contact ID {contact.ContactsID}: ");
            Console.Write("Enter FirstName : ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter LastName : ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Email : ");
            contact.Email = Console.ReadLine();

            Console.Write("Enter Phone : ");
            contact.Phone = Console.ReadLine();

            Console.Write("Enter Address : ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter CountryID : ");
            int countryId;
            while (!int.TryParse(Console.ReadLine(), out countryId))
            {
                Console.Write("Invalid ID. Enter a valid Country ID: ");
            }
            contact.CountryID = countryId;
        }

        // 4. دالة تشغيل منطق البحث 1
        static void ExecuteSearchLogic()
        {
            Console.Clear();
            Console.WriteLine("--- Search Contact ---");
            int idToSearch = EnterNumberByMessage("Enter Contact ID to search (or 0 to Back)");

            if (idToSearch == 0) return; // يعود بنا إلى القائمة الرئيسية

            stcontact contact = new stcontact();
            if (ContactRepository.SearchContactByID(idToSearch, ref contact))
            {
                PrintContact(contact);
            }
            else
            {
                Console.WriteLine("Error: Contact Not Found");
            }

            Console.WriteLine("\nPress any key to return to Main Menu...");
            Console.ReadKey();
        }

        // 5.  2 دالة تشغيل منطق التحديث 
        static void ExecuteUpdateLogic()
        {
            Console.Clear();
            Console.WriteLine("--- Update Contact Info ---");
            int idToUpdate = EnterNumberByMessage("Enter Contact ID to Update (or 0 to Back)");

            if (idToUpdate == 0) return;

            stcontact contact = new stcontact();
            if (ContactRepository.SearchContactByID(idToUpdate, ref contact))
            {
                PrintContact(contact);
                UpdateFullContactInfo(ref contact);

                if (ContactRepository.UpdateRecordContact(contact))
                {
                    Console.WriteLine("Ok, Updated Successfully.");
                    Console.WriteLine("___________________________ New Info ___________________________");
                    PrintContact(contact);
                }
                else
                {
                    Console.WriteLine("Error: Update Failed.");
                }
            }
            else
            {
                Console.WriteLine("Error: Contact Not Found");
            }

            Console.WriteLine("\nPress any key to return to Main Menu...");
            Console.ReadKey();
        }

        // 6. 3 دالة تشغيل منطق الحذف 
        static void ExecuteDeleteLogic()
        {
            Console.Clear();
            Console.WriteLine("--- Delete Contact ---");
            int idToDelete = EnterNumberByMessage("Enter Contact ID to Delete (or 0 to Back)");

            if (idToDelete == 0) return;

            if (ContactRepository.DeleteContact(idToDelete))
            {
                Console.WriteLine("Success: Contact Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("Error: Contact Not Found or couldn't be deleted.");
            }

            Console.WriteLine("\nPress any key to return to Main Menu...");
            Console.ReadKey();
        }

     
        static void Main(string[] args)
        {
            int choice = -1;

            while (choice != 0)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("     Contacts Management System         ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Search For Contact");
                Console.WriteLine("2. Update Contact Info");
                Console.WriteLine("3. Delete Contact");
                //Console.WriteLine("4. Add New Contact ");
                Console.WriteLine("0. Exit Program");
                Console.WriteLine("========================================");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ExecuteSearchLogic();
                            break;
                        case 2:
                            ExecuteUpdateLogic();
                            break;
                        case 3:
                            ExecuteDeleteLogic();
                            break;
                        case 0:
                            Console.WriteLine("\nGoodbye!");
                            break;
                        default:
                            Console.WriteLine("\nInvalid option! Press any key to try again.");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
    }
}