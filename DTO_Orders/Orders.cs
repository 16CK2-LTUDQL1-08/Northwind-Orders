using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Orders
{
    public class Orders
    {
        public int _OderID;
        public string _CustomerID;
        public int _EmployeeID;
        public DateTime _OrderDate;
        public DateTime _RequiredDate;
        public DateTime _ShippedDate;
        public int _ShipVia;
        public float _Freight;
        public string _ShipName;
        public string _ShipAddress;
        public string _ShipCity;
        public string _ShipRegion;
        public string _ShipPostalCode;
        public string _ShipCountry;

        public string CustomerID
        {
            get
            {
                return _CustomerID;
            }

            set
            {
                _CustomerID = value;
            }
        }

        public int OderID
        {
            get
            {
                return _OderID;
            }

            set
            {
                _OderID = value;
            }
        }

        public int EmployeeID
        {
            get
            {
                return _EmployeeID;
            }

            set
            {
                _EmployeeID = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return _OrderDate;
            }

            set
            {
                _OrderDate = value;
            }
        }

        public DateTime RequiredDate
        {
            get
            {
                return _RequiredDate;
            }

            set
            {
                _RequiredDate = value;
            }
        }

        public DateTime ShippedDate
        {
            get
            {
                return _ShippedDate;
            }

            set
            {
                _ShippedDate = value;
            }
        }

        public int ShipVia
        {
            get
            {
                return _ShipVia;
            }

            set
            {
                _ShipVia = value;
            }
        }

        public float Freight
        {
            get
            {
                return _Freight;
            }

            set
            {
                _Freight = value;
            }
        }

        public string ShipName
        {
            get
            {
                return _ShipName;
            }

            set
            {
                _ShipName = value;
            }
        }

        public string ShipAddress
        {
            get
            {
                return _ShipAddress;
            }

            set
            {
                _ShipAddress = value;
            }
        }

        public string ShipCity
        {
            get
            {
                return _ShipCity;
            }

            set
            {
                _ShipCity = value;
            }
        }

        public string ShipRegion
        {
            get
            {
                return _ShipRegion;
            }

            set
            {
                _ShipRegion = value;
            }
        }

        public string ShipPostalCode
        {
            get
            {
                return _ShipPostalCode;
            }

            set
            {
                _ShipPostalCode = value;
            }
        }

        public string ShipCountry
        {
            get
            {
                return _ShipCountry;
            }

            set
            {
                _ShipCountry = value;
            }
        }

        public Orders(int OID, string CID, int EID, DateTime ODate, DateTime RDate, DateTime SDate, int SVia, float Freights, string SName, string SAddress, string SCity, string SRegion, string SPostalCode, string SCountry)
        {
            this.OderID = OID;
            this.CustomerID = CID;
            this.EmployeeID = EID;
            this.OrderDate = ODate;
            this.RequiredDate = RDate;
            this.ShippedDate = SDate;
            this.ShipVia = SVia;
            this.Freight = Freights;
            this.ShipName = SName;
            this.ShipAddress = SAddress;
            this.ShipCity = SCity;
            this.ShipRegion = SRegion;
            this.ShipPostalCode = SPostalCode;
            this.ShipCountry = SCountry;


        }
    }
}
