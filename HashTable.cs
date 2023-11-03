using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp5
{



  public  class HashTable<TKey, TValue>
    {
        private List<TValue>[] items;

        public HashTable(int size)
        {
            items = new List<TValue>[size];
        }

        public void Add(TKey key, TValue value)
        {
            var k = GetHash(key);
            if (items[k] == null)
            {
                items[k] = new List<TValue>() { value };
            }
            else
            {
                items[k].Add(value);
            }
        }

        public bool Search(TKey key, TValue item)
        {
            var k = GetHash(key);
            return items[k]?.Contains(item) ?? false;
        }

        private int GetHash(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));
        }
    }
    //public  class HashTable
    //  {
    //      private int size;

    //      Dictionary <string, Student> keyValuePairs = new Dictionary <string, Student>();
    // //     keyValuePairs.TryGetValue
    //      //   private List<KeyValuePair<string, Student>> buckets;
    //    //  public string SearhComand(Действия действия)
    //    //  {

    //    //      string Value = string.Empty;
    //    //      // Пример вывода значения по ключу
    //    //      //  Действия action = действия;
    //    //var s=   =  keyValuePairs.FirstOrDefault(U =>U.Key ==);



    //    //  }


    //      public HashTable()
    //      {
    //          //this.size = size;

    //         // this.buckets = new List<KeyValuePair<string, Student>>


    //      }

    //      private int Hash(string key)
    //      {
    //          using (SHA256 hashAlgo = SHA256.Create())
    //          {
    //              byte[] hashBytes = hashAlgo.ComputeHash(Encoding.UTF8.GetBytes(key));
    //              string hashHex = BitConverter.ToString(hashBytes).Replace("-", "");
    //              BigInteger hashValue = BigInteger.Parse(hashHex, NumberStyles.HexNumber);
    //              return (int)(hashValue % size);
    //          }
    //      }

    //      public void Update(string key, Student value)
    //      {

    //      //    buckets.Add();
    //          int hashValue = Hash(key);


    //        //  keyValuePairs[hashValue];
    //          keyValuePairs.Add(hashValue.ToString(), value);
    //          //var bucket = buckets[hashValue];
    //          //if (bucket != null)
    //          //{
    //          //    foreach (var pair in bucket)
    //          //    {
    //          //        if (pair.Key == key)
    //          //        {
    //          //            bucket.Remove(pair);
    //          //            break;
    //          //        }
    //          //    }
    //          //}
    //          //else
    //          //{
    //          //    bucket = new List<KeyValuePair<string, Student>>();
    //          //    buckets[hashValue] = bucket;
    //          //}
    //          //bucket.Add(new KeyValuePair<string, Student>(key, value));
    //      }

    //      public Student Insert(string key, Student value)
    //      {


    //          //  buckets
    //          int hashValue = Hash(key);
    //          keyValuePairs.Add(hashValue.ToString(), value);

    //          Student student = null;
    //          if (keyValuePairs.TryGetValue(hashValue.ToString(), out Student actionName))
    //          {
    //              student = actionName;
    //              //       Console.WriteLine($"Действие: {actionName}");

    //          }
    //          else
    //          {
    //              //     Console.WriteLine("Действие не найдено в словаре.");
    //          }
    //          return student;
    //          //var bucket = buckets[hashValue];
    //          //bucket = new List<KeyValuePair<string, Student>>();
    //          //bucket.Add(new KeyValuePair<string, Student>(key, value));
    //          //buckets = bucket;

    //          //if (bucket != null)
    //          //{
    //          //    foreach (var pair in bucket)
    //          //    {
    //          //        if (pair.Key == key && pair.Value == value)
    //          //        {
    //          //            return;
    //          //        }
    //          //    }
    //          //}
    //          //else
    //          //{
    //          //    bucket = new List<KeyValuePair<string, Student>>();
    //          //    buckets[hashValue] = bucket;
    //          //}

    //      }

    //      //public Student Get(string key)
    //      //{
    //      //    int hashValue = Hash(key);
    //      //    var bucket = buckets[hashValue];
    //      //    if (bucket != null)
    //      //    {
    //      //        foreach (var pair in bucket)
    //      //        {
    //      //            if (pair.Key == key)
    //      //            {
    //      //                return pair.Value;
    //      //            }
    //      //        }
    //      //    }
    //      //    return null;
    //      //}

    //      //public void Delete(string key)
    //      //{
    //      //    int hashValue = Hash(key);
    //      //    var bucket = buckets[hashValue];
    //      //    if (bucket != null)
    //      //    {
    //      //        foreach (var pair in bucket)
    //      //        {
    //      //            if (pair.Key == key)
    //      //            {
    //      //                bucket.Remove(pair);
    //      //                return;
    //      //            }
    //      //        }
    //      //    }
    //      //}
    //  }
}
