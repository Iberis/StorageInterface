using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageInterface
{
    public class Item : IEquatable<Item>
    {
        public int StorageId { get; }
        public int Amount { get; }
        public bool Overwrite { get; }
        public bool IsInvalid { get; }

        public Item(int StorageId, int Amount, bool Overwrite = false)
        {
            this.StorageId = StorageId;
            IsInvalid = (Overwrite && Amount < 0) || (!Overwrite && Amount == 0);

            if (IsInvalid)
            {
                this.Amount = 0;
                this.Overwrite = false;
            }
            else
            {
                this.Amount = Amount;
                this.Overwrite = Overwrite;
            }
        }

        public override string ToString()
        {
            string returnString = "ID: " + StorageId + ", ";

            if (IsInvalid)
                return returnString + "INVALID value input is being ignored";

            string plusSign = "";
            if (!Overwrite && Amount > 0)
                plusSign = "+";

            returnString += "change: " + plusSign + Amount;

            if (Overwrite)
                returnString += " >> SET AS TOTAL";

            return returnString;
        }

        bool IEquatable<Item>.Equals(Item other)
        {
            return 
                (StorageId.Equals(other.StorageId) 
                && Amount.Equals(other.Amount) 
                && Overwrite.Equals(other.Overwrite));
        }
    }
}
