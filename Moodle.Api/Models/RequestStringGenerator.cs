using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Api.Models
{
    public class RequestStringGenerator 
    {
        public List<KeyValuePair<string, string>> DynamicKeyValuePairsOnlyNonList(string prefix = "")
        {
            var keyValuePairs = new List<KeyValuePair<string, string>>();







            // Turkish: Modelde tanımlı değişkenleri Moodle Sistemine gönderecek formata sokar. Listeler hariç onlar özel olarak tanımlanmalıdır.
            foreach (var property in this.GetType().GetProperties())
            {
                if (!property.ToString().Contains("System.Collections.Generic.List"))
                {
                    if (property.GetValue(this) != null)
                        keyValuePairs.Add(new KeyValuePair<string, string>(ModelHelper.GetPrefixedName(property.Name, prefix), property.GetValue(this).ToString()));
                    else
                        keyValuePairs.Add(new KeyValuePair<string, string>(ModelHelper.GetPrefixedName(property.Name, prefix), string.Empty));
                }
                else
                {

                }
                #region Test - Dynamic Key Value Pair For List
                //  else
                //  {
                //	var typee = property.GetType();
                //	var tee = property.GetValue(this) ;


                //	//keyValuePairs.AddRange(ToKeyValuePairsList(property));

                //}
                #endregion
            }



            return keyValuePairs;
        }
         



        #region Test - Dynamic Key Value Pair For List 


        /*
        public async Task<List<KeyValuePair<string, string>>> ToKeyValuePairsList<TInput>(TInput input)
        where TInput : System.Collections.IEnumerable
        {
            var keyValuePairs = new List<KeyValuePair<string, string>>();
            int i = 0;

            foreach (var item in input)
            {
                var tip = typeof(item);

                var inputItems = await ToKeyItem < typeof(item) > (item, i);
                keyValuePairs.Add(inputItems);

                i++;
            }

            return keyValuePairs;
        }


        public async Task<List<KeyValuePair<string, string>>> ToKeyItem<TInput>(TInput input, int i = 0)
        where TInput : IModel
        {

            return input.ToKeyValuePairs("input[" + i.ToString() + "]");

        }
        */


        #endregion

    }
}
