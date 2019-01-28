using System.Text;

namespace UnityExtension
{
    public static class StringEx
    {
        private static StringBuilder builder = new StringBuilder();

        public static string Format(string format, object arg)
        {
            builder.Length = 0;
            builder.AppendFormat(format, arg);
            return builder.ToString();
        }

        public static string Format(string format, object arg1, object arg2)
        {
            builder.Length = 0;
            builder.AppendFormat(format, arg1, arg2);
            return builder.ToString();
        }

        public static string Format(string format, object arg1, object arg2, object arg3)
        {
            builder.Length = 0;
            builder.AppendFormat(format, arg1, arg2, arg3);
            return builder.ToString();
        }

        public static string Format(string format, params object[] args)
        {
            if (string.IsNullOrEmpty(format))
                return string.Empty;
            if (args == null || args.Length == 0)
                return string.Empty;

            builder.Length = 0;
            builder.AppendFormat(format, args);
            return builder.ToString();
        }

        public static string Concat(string arg0, string arg1)
        {
            builder.Length = 0;
            builder.Append(arg0);
            builder.Append(arg1);
            return builder.ToString();
        }

        public static string Concat(string arg0, string arg1, string arg2)
        {
            builder.Length = 0;
            builder.Append(arg0);
            builder.Append(arg1);
            builder.Append(arg2);
            return builder.ToString();
        }

        public static string Concat(string arg0, string arg1, string arg2, string arg3)
        {
            builder.Length = 0;
            builder.Append(arg0);
            builder.Append(arg1);
            builder.Append(arg2);
            builder.Append(arg3);
            return builder.ToString();
        }

        public static string Concat(params string[] args)
        {
            if (args == null || args.Length == 0)
                return string.Empty;

            builder.Length = 0;
            for (int i = 0; i < args.Length; i++)
            {
                builder.Append(args[i]);
            }
            return builder.ToString();
        }

        public static string Concat(object arg0, object arg1)
        {
            builder.Length = 0;
            builder.Append(arg0);
            builder.Append(arg1);
            return builder.ToString();
        }

        public static string Concat(object arg0, object arg1, object arg2)
        {
            builder.Length = 0;
            builder.Append(arg0);
            builder.Append(arg1);
            builder.Append(arg2);
            return builder.ToString();
        }

        public static string Concat(object arg0, object arg1, object arg2, object arg3)
        {
            builder.Length = 0;
            builder.Append(arg0);
            builder.Append(arg1);
            builder.Append(arg2);
            builder.Append(arg3);
            return builder.ToString();
        }

        public static string Concat(params object[] args)
        {
            if (args == null || args.Length == 0)
                return string.Empty;

            builder.Length = 0;
            for (int i = 0; i < args.Length; i++)
            {
                builder.Append(args[i].ToString());
            }
            return builder.ToString();
        }

        public static string Join(string separator, string[] value)
        {
            if (value != null && value.Length > 0)
            {
                builder.Length = 0;
                for (int i = 0, j = 1; i < value.Length; i++, j++)
                {
                    builder.Append(value[i]);
                    if (j < value.Length)
                        builder.Append(separator);
                }
                return builder.ToString();
            }
            return string.Empty;
        }

        public static string Join(string separator, params object[] args)
        {
            if (args != null && args.Length > 0)
            {
                builder.Length = 0;
                for (int i = 0, j = 1; i < args.Length; i++, j++)
                {
                    builder.Append(args[i]);
                    if (j < args.Length)
                        builder.Append(separator);
                }
                return builder.ToString();
            }
            return string.Empty;
        }

        public static string Combine(params string[] values)
        {
            string value = string.Empty;
            for (int i = 0; i < values.Length; i++)
            {
                if (!string.IsNullOrEmpty(value))
                    value = Join("/", value, values[i]);
                else
                    value = values[i];
            }
            return value;
        }
    }
}