using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;

namespace REflexion_GetField
{
    [System.AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class DataMappingAttribute : System.Attribute
    {
        public string ColumnName { get; set; }
        public string PropertyName { get; set; }

        public DataMappingAttribute(string columnName, string propertyName)
        {
            ColumnName = columnName;
            PropertyName = propertyName;
        }
    }

    class ReflectionExample
    {
        private string _privateField = "Hello";
        public string _publicField = "Goodbye";
        internal string _internalfield = "Hola";
        protected string _protectedField = "Adios";
        static string _staticField = "Bonjour";

        public string PrivateField
        {
            get { return _privateField; }
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public static bool LoadClassFromSQLDataReader(object myClass, SqlDataReader dr)
        {
            if (dr.HasRows)
            {
                dr.Read();

                Type typeOfClass = myClass.GetType();

                object[] dataMappingAttributes = typeOfClass.GetCustomAttributes(typeof(DataMappingAttribute), false);

                for (int columnIndex = 0; columnIndex <= dr.FieldCount - 1; columnIndex++)
                {
                    //Get the name of the column.
                    string columnName = dr.GetName(columnIndex);

                    //Check if a property exists that matches that name.
                    PropertyInfo propertyInfo = null;

                    //Check if an attribute exists that maps this column to a property.
                    foreach (DataMappingAttribute dataMappingAttribute in dataMappingAttributes)
                    {
                        if (dataMappingAttribute.ColumnName == columnName)
                        {
                            propertyInfo = typeOfClass.GetProperty(dataMappingAttribute.PropertyName);
                            break;
                        }
                    }

                    //The the property was mapped explicitely then try to find a
                    //property with the same name as the column.
                    if (propertyInfo == null)
                    {
                        propertyInfo = typeOfClass.GetProperty(columnName);
                    }

                    //If you found a property then set its value.
                    if (propertyInfo != null)
                    {
                        //Set the value to the value in the SqlDataReader
                        propertyInfo.SetValue(myClass, dr.GetValue(columnIndex));
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReflectionExample reflectionExample = new ReflectionExample();
            Type reflectionExampleType = typeof(ReflectionExample);

            FieldInfo[] fields = reflectionExampleType.GetFields(
                BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.NonPublic |
                BindingFlags.FlattenHierarchy);

            foreach (FieldInfo field in fields)
            {
                object fieldValue = field.GetValue(reflectionExample);

                Debug.WriteLine(string.Format("Field Name: {0}, Value: {1}", field.Name, fieldValue.ToString()));
                Console.WriteLine(string.Format("Field Name: {0}, Value: {1}", field.Name, fieldValue.ToString()));
            }

            reflectionExampleType.GetField("_privateField", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(reflectionExample, "My New Value");

            Console.WriteLine(string.Format("Private Field Value: {0}", reflectionExample.PrivateField));

            Console.ReadKey();
        }
    }
}
