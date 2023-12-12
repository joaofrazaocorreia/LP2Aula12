using System;

namespace LazySingleFloat
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance = instance.Value;
        public float MyValue { get; set; }

        private Singleton() { }
    }
}