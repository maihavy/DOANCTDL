using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_CTDL
{
    class BinarySearchTree
    {
        public Node Root { get; set; }

        public bool Insert(DanhBa songuoidung)
        {
            Node before = null;
            Node after = this.Root;
            while (after != null)
            {
                before = after;
                if (songuoidung.getSoLanCuocGoi() <= after.Data.getSoLanCuocGoi())
                    after = after.LeftNode;
                else
                {
                    after = after.RightNode;
                }
            }
            Node newNode = new Node();
            newNode.Data = songuoidung;
            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (songuoidung.getSoLanCuocGoi() <= before.Data.getSoLanCuocGoi())
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }

        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.WriteLine(parent.Data);
                TraverseInOrder(parent.RightNode);
            }
        }
        public void FindHoTen(string hoten, Node parent)
        {
            if (parent != null)
            {
                if (parent.Data.getHoTen().Contains(hoten, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(parent.Data);
                    FindHoTen(hoten, parent.LeftNode);
                    FindHoTen(hoten, parent.RightNode);
                }
                else
                {
                    FindHoTen(hoten, parent.LeftNode);
                    FindHoTen(hoten, parent.RightNode);
                }
            }
        }

        public void FindMaVung(int mavung, Node parent)
        {
            if (parent != null)
            {
                if (mavung == parent.Data.getMaVung())
                {
                    Console.WriteLine(parent.Data);
                    FindMaVung(mavung, parent.LeftNode);
                    FindMaVung(mavung, parent.RightNode);
                }
                else
                {
                    FindMaVung(mavung, parent.LeftNode);
                    FindMaVung(mavung, parent.RightNode);
                }
            }
        }

        public void FindEmail(string email, Node parent)
        {
            if (parent != null)
            {
                if (parent.Data.getEmail() == email)
                {
                    Console.WriteLine(parent.Data);
                    FindEmail(email, parent.LeftNode);
                    FindEmail(email, parent.RightNode);
                }
                else
                {
                    FindEmail(email, parent.LeftNode);
                    FindEmail(email, parent.RightNode);
                }
            }
        }

        public void FindSĐT(string sđt, Node parent)
        {
            if (parent != null)
            {
                if (sđt == parent.Data.getSĐT())
                {
                    Console.WriteLine(parent.Data);
                    FindSĐT(sđt, parent.LeftNode);
                    FindSĐT(sđt, parent.RightNode);
                }
                else
                {
                    FindSĐT(sđt, parent.LeftNode);
                    FindSĐT(sđt, parent.RightNode);
                }
            }
        }

        public void FindNhan(string key, Node parent)
        {
            if (parent != null)
            {
                if (parent.Data.getNhanDB().Contains(key,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(parent.Data);
                    FindNhan(key, parent.LeftNode);
                    FindNhan(key, parent.RightNode);
                }
                else
                {
                    FindNhan(key, parent.LeftNode);
                    FindNhan(key, parent.RightNode);
                }
            }
        }
        public void FindThang(int thang, Node parent)
        {
            if (parent != null)
            {
                if (thang == parent.Data.getThang())
                {
                    Console.WriteLine(parent.Data);
                    FindThang(thang, parent.LeftNode);
                    FindThang(thang, parent.RightNode);
                }
                else
                {
                    FindThang(thang, parent.LeftNode);
                    FindThang(thang, parent.RightNode);
                }
            }
        }
        public void FindNam(int nam, Node parent)
        {
            if (parent != null)
            {
                if (nam == parent.Data.getNam())
                {
                    Console.WriteLine(parent.Data);
                    FindNam(nam, parent.LeftNode);
                    FindNam(nam, parent.RightNode);
                }
                else
                {
                    FindNam(nam, parent.LeftNode);
                    FindNam(nam, parent.RightNode);
                }
            }
        }
        public void FindDOB(int ngay, int thang, int nam, Node parent)
        {
            if (parent != null)
            {
                if (parent.Data.getNgay() == ngay && parent.Data.getThang() == thang && parent.Data.getNam()==nam)
                {
                    Console.WriteLine(parent.Data);
                    FindDOB(ngay, thang, nam, parent.LeftNode);
                    FindDOB(ngay, thang, nam, parent.RightNode);
                }
                else
                {
                    FindDOB(ngay, thang, nam, parent.LeftNode);
                    FindDOB(ngay, thang, nam, parent.RightNode);
                }
            }
        }
        public void Findx2(string gioitinh, int mavung, Node parent)
        {
            if (parent != null)
            {
                if (parent.Data.getGioiTinh() == gioitinh && parent.Data.getMaVung() == mavung)
                {
                    Console.WriteLine(parent.Data);
                    Findx2(gioitinh, mavung, parent.LeftNode);
                    Findx2(gioitinh, mavung, parent.RightNode);
                }
                else
                {
                    Findx2(gioitinh, mavung, parent.LeftNode);
                    Findx2(gioitinh, mavung, parent.RightNode);
                }
            }
        }
        public void Findkethop(string hoten, int mavung, Node parent)
        {
            if (parent != null)
            {
                if (parent.Data.getHoTen().Contains(hoten, StringComparison.OrdinalIgnoreCase) && parent.Data.getMaVung() == mavung)
                {
                    Console.WriteLine(parent.Data);
                    Findkethop(hoten, mavung, parent.LeftNode);
                    Findkethop(hoten, mavung, parent.RightNode);
                }
                else
                {
                    Findkethop(hoten, mavung, parent.LeftNode);
                    Findkethop(hoten, mavung, parent.RightNode);
                }
            }
        }
        public void Findkh(string hoten, int thang, Node parent)
        {
            if (parent != null)
            {
                if (parent.Data.getHoTen().Contains(hoten, StringComparison.OrdinalIgnoreCase) && parent.Data.getThang() == thang)
                {
                    Console.WriteLine(parent.Data);
                    Findkh(hoten, thang, parent.LeftNode);
                    Findkh(hoten, thang, parent.RightNode);
                }
                else
                {
                    Findkh(hoten, thang, parent.LeftNode);
                    Findkh(hoten, thang, parent.RightNode);
                }
            }
        }
        public void Findthang(int a, int b, Node parent)
        {
            if (parent != null)
            {
                if (a <= parent.Data.getThang() && parent.Data.getThang() <= b)
                {
                    Console.WriteLine(parent.Data);
                    Findthang(a, b, parent.LeftNode);
                    Findthang(a, b, parent.RightNode);
                }
                else
                {
                    Findthang(a, b, parent.LeftNode);
                    Findthang(a, b, parent.RightNode);
                }
            }
        }

        public void FindMin(Node node)
        {
            if (node != null)
            {
                if (MinValueOfNode(this.Root) == node.Data.getSoLanCuocGoi())
                {
                    Console.WriteLine(node.Data);
                    FindMin(node.LeftNode);
                }
                else
                {
                    FindMin(node.LeftNode);
                }
            }
        }

        public int MinValueOfNode(Node node)
        {
            int min = node.Data.getSoLanCuocGoi();
            while (node.LeftNode != null)
            {
                if (min >= node.LeftNode.Data.getSoLanCuocGoi())
                {
                    min = node.LeftNode.Data.getSoLanCuocGoi();
                    node = node.LeftNode;
                }
                else
                {
                    break;
                }
            }
            return min;
        }

        public void FindMax(Node node)
        {
            if (node != null)
            {
                if (MaxValueOfNode(this.Root) == node.Data.getSoLanCuocGoi())
                {
                    Console.WriteLine(node.Data);
                    FindMax(node.LeftNode);
                    FindMax(node.RightNode);
                }
                else
                {
                    FindMax(node.RightNode);
                }
            }
        }

        private int MaxValueOfNode(Node node)
        {
            int max = node.Data.getSoLanCuocGoi();
            while (node.RightNode != null)
            {
                if (max < node.RightNode.Data.getSoLanCuocGoi())
                {
                    max = node.RightNode.Data.getSoLanCuocGoi();
                    node = node.RightNode;
                }
                else
                {
                    break;
                }
            }
            return max;
        }
    }
}
