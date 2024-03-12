using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageInterface
{
    /*
     * This class is used to store elements of SQLite Query Conditions
     * This class is used to initialise and identify control elements in the UI
     * and resolve them into their specific properties.
     * The actual value to compare against is not included in this class,
     * because it is provided by the user during runtime. See below.
     */
    public class Condition
    {
        public string Column { get; }
        public string Operator { get; }
        // The type of the variables stored in the column at the Database.
        // e.g. int, string, etc.
        public Type Type { get; }

        public Condition(string Column, string Operator, Type Type)
        {
            this.Column = Column;
            this.Operator = Operator;
            this.Type = Type;
        }
    }

    // This abstract class purely exists to allow bundling of generic ValueConditions.
    public abstract class GenericValueCondition : Condition
    {
        public object Value { get; }
        public GenericValueCondition(string Column, string Operator, object Value) : base(Column, Operator, Value.GetType())
        {
            this.Value = Value;
        }

        public GenericValueCondition(Condition condition, object Value) : this(condition.Column, condition.Operator, Value) { }
    }

    public class ValueCondition<T> : GenericValueCondition
    {
        public new T Value { get; }
        public ValueCondition(string Column, string Operator, T Value) : base(Column, Operator, Value)
        {
            this.Value = Value;
        }

        public ValueCondition(Condition condition, T Value) : this(condition.Column, condition.Operator, Value) { }
    }

    public class StringCondition : ValueCondition<string>
    {
        public string ValuePure { get; }

        public StringCondition(string Column, string Value, string Operator = "LIKE") : base(Column, Operator, "%" + Value + "%")
        {
            this.ValuePure = Value;
        }

        public StringCondition(Condition condition, string Value) : this(condition.Column, Value, condition.Operator) { }
    }
}
