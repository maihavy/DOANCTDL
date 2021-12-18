using System;

namespace DO_AN_CTDL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            BinarySearchTree binerytree = new BinarySearchTree();
            binerytree.Insert(new DanhBa(7, "Huỳnh Văn Trinh", 28, "vt@gmail.com", "0975682367", "Bạn cấp 1", "nữ", 16, 3, 2002));
            binerytree.Insert(new DanhBa(4, "Lê Thị Tuyết Nhung", 28, "tn@gmail.com", "0968532148", "Bạn đại học", "nữ", 21, 2, 2002));
            binerytree.Insert(new DanhBa(6, "Bạch Ngọc Minh Trúc", 28, "mt@gmail.com", "0758621458", "Bạn nước ngoài", "nữ", 23, 12, 2001));
            binerytree.Insert(new DanhBa(4, "Huỳnh Thị Cẩm Nhung", 235, "cn@gmail.com", "0985632847", "Bạn đại học", "nữ", 26, 11, 1991));
            binerytree.Insert(new DanhBa(8, "Mai Hạ Vy", 236, "havy@gmail.com", "0987564235", "Bạn thân", "nữ", 23, 12, 1993));
            binerytree.Insert(new DanhBa(22, "Thảo Vy", 269, "thaovy@gmail.com", "0786932554", "Bạn thân", "nữ", 8, 5, 1995));
            binerytree.Insert(new DanhBa(30, "Mẹ", 275, "me@gmail.com", "0123456789", "Nhà", "nữ", 9, 7, 1977));
            binerytree.Insert(new DanhBa(30, "Ba", 275, "ba@gmail.com", "0123449324", "Nhà", "nam", 5, 1, 1974));
            binerytree.Insert(new DanhBa(9, "Chị", 275, "chi@gmail.com", "0124759329", "Nhà", "nữ", 4, 6, 1994));
            binerytree.Insert(new DanhBa(8, "Anh", 275, "anh@gmail.com", "0987654321", "Nhà", "nam", 2, 1, 1996));
            binerytree.Insert(new DanhBa(1, "Dì 8", 275, "di8@gmail.com", "01885456789", "Hàng xóm", "nữ", 24, 7, 1969));
            binerytree.Insert(new DanhBa(1, "Chú 6", 275, "chu6@gmail.com", "0373457777", "Hàng xóm", "nam", 1, 10, 1980));
            binerytree.Insert(new DanhBa(2, "Dì 4", 277, "di4@gmail.com", "0911675479", "Bạn cấp 1", "nữ", 5, 6, 1970));
            binerytree.Insert(new DanhBa(2, "Chị Lan", 239, "lan@gmail.com", "0975422767", "Bạn cấp 1", "nữ", 3, 2, 1997));
            binerytree.Insert(new DanhBa(10, "Chú 8", 220, "chu8@gmail.com", "0909069999", "Hàng xóm", "nam", 31, 12, 1985));
            binerytree.Insert(new DanhBa(19, "Minh Tùng", 236, "tung@gmail.com", "0131234064", "Bạn chung trọ", "nam", 20, 10, 1999));
            binerytree.Insert(new DanhBa(2, "Xuân", 277, "xuan@gmail.com", "0911675479", "Bạn cấp 1", "nam", 22, 5, 2002));
            binerytree.Insert(new DanhBa(2, "Hạ", 239, "ha@gmail.com", "0975422767", "Bạn cấp 1", "nữ", 11, 6, 2002));
            binerytree.Insert(new DanhBa(10, "Thu", 220, "thu@gmail.com", "0909066688", "Bạn đại học", "nữ", 28, 10, 2002));
            binerytree.Insert(new DanhBa(19, "Xuân Đông", 236, "xuandong@gmail.com", "0934005605", "Bạn chung trọ", "nam", 24, 2, 2002));
            binerytree.Insert(new DanhBa(19, "Xuân Đông", 28, "dong@gmail.com", "0131234064", "Bạn đại học", "nữ", 9, 8, 2002));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0," + (Console.WindowWidth + 35) / 2 + "}", "ĐỒ ÁN CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT");
            Console.WriteLine("{0," + (Console.WindowWidth + 50) / 2 + "}", "NHÓM 3 - LỚP: DS001 - MÃ LỚP HỌC PHẦN: 21C1INF50900702");
            Console.WriteLine("{0," + (Console.WindowWidth + 45) / 2 + "}", "CÂY TÌM KIẾM NHỊ PHÂN VÀ ỨNG DỤNG TRONG QUẢN LÝ");
            Console.WriteLine("{0," + (Console.WindowWidth + 12) / 2 + "}", "DANH BẠ ĐIỆN THOẠI");
            Console.WriteLine("{0," + (Console.WindowWidth + 8) / 2 + "}", "*************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cú pháp danh bạ: (số lần gọi, tên liên hệ, mã vùng, email, số điện thoại, nhãn, giới tính)");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            binerytree.TraverseInOrder(binerytree.Root);
        MENU:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("Nhập 1 để tìm kiếm theo tên người cần liên hệ");
            Console.WriteLine("Nhập 2 để tìm kiếm theo mã vùng");
            Console.WriteLine("Nhập 3 để tìm kiếm theo email");
            Console.WriteLine("Nhập 4 để tìm kiếm theo số điện thoại");
            Console.WriteLine("Nhập 5 để tìm kiếm theo nhãn danh bạ");
            Console.WriteLine("Nhập 6 để tìm kiếm theo tháng sinh");
            Console.WriteLine("Nhập 7 để tìm kiếm theo năm sinh");
            Console.WriteLine("Nhập 8 để tìm kiếm theo ngày-tháng-năm sinh");
            Console.WriteLine("Nhập 9 để tìm kiếm theo tên liên hệ và tháng sinh");
            Console.WriteLine("Nhập 10 để tìm kiếm theo giới tính và mã vùng");
            Console.WriteLine("Nhập 11 để tìm kiếm theo mã vùng và tên liên hệ");
            Console.WriteLine("Nhập 12 để tìm kiếm liên hệ có tháng sinh trong khoảng");
            Console.WriteLine("Nhập 13 để tìm liên hệ gọi nhiều nhất và ít nhất");
            Console.WriteLine("Nhập 14 để thêm liên hệ");
            Console.WriteLine("Nhập 15 để kết thúc chương trình");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            switch (n)
            {
                case 1:
                    Console.Write("\nTên Người Mà Bạn Muốn Tìm Trong Danh Bạ: ");
                    string hoten = Console.ReadLine();
                    binerytree.FindHoTen(hoten, binerytree.Root);
                    goto MENU;
                case 2:
                    Console.Write("\nSố Mã Vùng Mà Bạn Muốn Tìm Trong Danh Bạ: ");
                    int mavung = int.Parse(Console.ReadLine());
                    binerytree.FindMaVung(mavung, binerytree.Root);
                    goto MENU;
                case 3:
                    Console.Write("\nEmail Người Dùng Mà Bạn Muốn Tìm Trong Danh Bạ: ");
                    string email = Console.ReadLine();
                    binerytree.FindEmail(email, binerytree.Root);
                    goto MENU;
                case 4:
                    Console.Write("\nSố Điện Thoại Mà Bạn Muốn Tìm Trong Danh Bạ: ");
                    string sđt = Console.ReadLine();
                    binerytree.FindSĐT(sđt, binerytree.Root);
                    goto MENU;
                case 5:
                    Console.Write("\nNhãn Danh Bạ Mà Bạn Muốn Tìm: ");
                    string nhan = Console.ReadLine();
                    binerytree.FindNhan(nhan, binerytree.Root);
                    goto MENU;
                case 6:
                    Console.Write("\nNhập tháng sinh: ");
                    int thang = int.Parse(Console.ReadLine());
                    binerytree.FindThang(thang, binerytree.Root);
                    goto MENU;                   
                case 7:
                    Console.Write("\nNhập năm sinh: ");
                    int nam = int.Parse(Console.ReadLine());
                    binerytree.FindNam(nam, binerytree.Root);
                    goto MENU;
                case 8:
                    Console.Write("\nNhập ngày sinh: ");
                    int day = int.Parse(Console.ReadLine());
                    Console.Write("\nNhập tháng sinh: ");
                    int month = int.Parse(Console.ReadLine());
                    Console.Write("\nNhập năm sinh: ");
                    int year = int.Parse(Console.ReadLine());
                    binerytree.FindDOB(day, month, year, binerytree.Root);
                    goto MENU;
                case 9:
                    Console.Write("\nNhập tên liên hệ: ");
                    string name = Convert.ToString(Console.ReadLine());
                    Console.Write("Nhập tháng sinh: ");
                    int m = int.Parse(Console.ReadLine());
                    binerytree.Findkh(name, m, binerytree.Root);
                    goto MENU;                           
                case 10:
                    Console.Write("\nNhập giới tính: ");
                    string gioitinh = Convert.ToString(Console.ReadLine());
                    Console.Write("\nNhập mã vùng: ");
                    int mavung1 = int.Parse(Console.ReadLine());
                    binerytree.Findx2(gioitinh, mavung1, binerytree.Root);
                    goto MENU;              
                case 11:
                    Console.Write("\nNhập tên liên hệ: ");
                    string ten = Convert.ToString(Console.ReadLine());
                    Console.Write("\nNhập mã vùng: ");
                    int mv = int.Parse(Console.ReadLine());
                    binerytree.Findkethop(ten, mv, binerytree.Root);
                    goto MENU;              
                case 12:                    
                    Console.Write("\nNhập tháng sinh đầu tiên: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("\nNhập tháng sinh thứ hai: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nSố liên hệ có tháng sinh từ tháng {0} đến tháng {1} là:", a,b);
                    binerytree.Findthang(a, b, binerytree.Root);
                    goto MENU;
                case 13:
                    Console.WriteLine("\nNgười Dùng có số lần cuộc gọi ít nhất:");
                    binerytree.FindMin(binerytree.Root);
                    Console.WriteLine("\nNgười Dùng có số lần cuộc gọi nhiều nhất:");
                    binerytree.FindMax(binerytree.Root);
                    goto MENU;
                case 14:
                    Console.WriteLine("Thêm liên hệ:");
                    Console.WriteLine("19, Thuận, 236, thuan@gmail.com, 0131234064, Bạn thân, nam");
                    Console.WriteLine("13, Linh, 254, linh@gmail.com, 0905123411, Bạn cấp 2, nữ");
                    Console.WriteLine();
                    binerytree.Insert(new DanhBa(19, "Thuận", 236, "thuan@gmail.com", "0131234064", "Bạn đại học", "nam", 22, 5, 2002));
                    binerytree.Insert(new DanhBa(13, "Linh", 254, "linh@gmail.com", "0905123411", "Bạn cấp 2", "nữ", 27, 7, 2001));
                    Console.WriteLine("Danh bạ sau khi thêm:");
                    binerytree.TraverseInOrder(binerytree.Root);
                    goto MENU;               
                case 15:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0," + (Console.WindowWidth + 22) / 2 + "}", " KẾT THÚC CHƯƠNG TRÌNH ");
                    break;
            }
            Console.ReadKey();

        }
    }
}
