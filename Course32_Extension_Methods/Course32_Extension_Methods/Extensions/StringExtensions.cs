namespace System {
    static class StringExtensions {

        public static string Cut(this string thisObj, int count) {
            if (thisObj.Length <= count) {
                return thisObj;
            }
            else {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
