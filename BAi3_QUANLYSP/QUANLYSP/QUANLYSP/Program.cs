using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using Abstract_SP;
using Xuli_Product;
using checkvalidate;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<AbProduct> productList = new List<AbProduct>();
            string continueChoice;

            do
            {
                Console.WriteLine("Chọn loại sản phẩm để nhập:");
                Console.WriteLine("1. Điện thoại");
                Console.WriteLine("2. Laptop");
                Console.WriteLine("3. Sách");
                Console.WriteLine("4. Đồ điện tử khác");
                Console.Write("Vui lòng chọn 1 trong 4 lựa chọn sau : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string phoneName = checkstrin.check_ten("tên điện thoại : ");
                        decimal phonePrice = checkvalidate.checkvalidate.check_validate();
                        Console.WriteLine("Nhập giá điện thoại");
                        string phoneBrand = checkstrin.check_hang();
                        productList.Add(new Phone(phoneName, phonePrice, phoneBrand));
                        break;
                    case "2":
                        string laptopName = checkstrin.check_ten("tên laptop : ");
                        Console.WriteLine("Nhập giá laptop");
                        decimal laptopPrice = checkvalidate.checkvalidate.check_validate();
                        string laptopBrand = checkstrin.check_hang();
                        productList.Add(new Xuli_Product.LapTop(laptopName, laptopPrice, laptopBrand));
                        break;
                    case "3":
                        string bookName = checkstrin.check_ten("tên sách : ");
                        Console.WriteLine("Nhập giá sách");
                        decimal bookPrice = checkvalidate.checkvalidate.check_validate();
                        string bookAuthor = checkstrin.check_ten("tên tác giả : ");
                        productList.Add(new Xuli_Product.Book(bookName, bookPrice, bookAuthor));
                        break;
                    case "4":
                        string electronicsName = checkstrin.check_ten("tên đồ điện tử: ");
                        Console.WriteLine("Nhập giá đồ điện tử :");
                        decimal electronicsPrice = checkvalidate.checkvalidate.check_validate();
                        string electronicsCategory = checkstrin.check_ten("tên loại đồ điện tử : ");
                        productList.Add(new Xuli_Product.Electronics(electronicsName, electronicsPrice, electronicsCategory));
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

                Console.WriteLine("Bạn có muốn nhập thêm sản phẩm khác không? (y/n)");
                continueChoice = Console.ReadLine().ToLower();

            } while (continueChoice == "y");

            Console.WriteLine("Danh sách sản phẩm đã nhập:");
            foreach (var product in productList)
            {
                Console.WriteLine(product.ToString());
            }

            Console.WriteLine("Chương trình đã kết thúc. Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
