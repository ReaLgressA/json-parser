using System.Collections;

namespace JsonParser {
    public interface IJsonInterface {
        void ToJsonObject(Hashtable ht);
        void FromJson(Hashtable ht, bool isAddition = false);
    }
}