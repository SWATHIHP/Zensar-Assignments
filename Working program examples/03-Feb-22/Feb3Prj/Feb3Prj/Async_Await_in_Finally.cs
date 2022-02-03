using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Async_Await_in_Finally
    {
        static void Main()
        {
            //addAsync();
            FileRead fr = new FileRead();
            Console.WriteLine("");
        }
        async static Task addAsync()
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 2;
            }
            catch (Exception e)
            {
                //use await in catch
                await otherException();
                Console.WriteLine("Waiting for some task completion");
            }
            finally
            {
                await releaseResources();

            }
        }

        private static Task releaseResources()
        {
            throw new NotImplementedException();
        }

        async static Task otherException()
        {
            Console.WriteLine("There was an index out of range exception in the array -arr");

        }
        async static Task releaseReswources()
        {
            Console.WriteLine("All alloted resources have been released");
        }
    }
    class FileRead
    {
        public async void filereadoperation()
        {
            try
            {
                StreamReader sr = File.OpenText(@"D:\message1.txt");
                Console.WriteLine($"The first line of the file is {sr.ReadLine()}");
                sr.Close();
            }
            catch { await FileNotFoundException(); }
            finally { await Exitprg(); }

            async Task FileNotFound()
            {
                Console.WriteLine();
            }

        }
    }
}