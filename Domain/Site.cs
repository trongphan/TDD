using System;

namespace Domain
{
    public class Site
    {
        private int _id;
        private string _name;

        private Site()
        {
        }

        private Site(string name)
        {
            _name = name;
        }

        public static Site Create(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            return new Site(name);
        }
    }
}
