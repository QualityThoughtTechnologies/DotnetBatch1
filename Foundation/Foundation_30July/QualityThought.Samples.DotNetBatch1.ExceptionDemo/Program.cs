﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityThought.Samples.DotNetBatch1.ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter any number");
            //string input = Console.ReadLine();
            //if(input=="NULL")
            //{
            //    input = null;
            //}

            //try
            //{
            //    int value = int.Parse(input);
            //}
            
            //catch(ArgumentNullException)
            //{
            //    Console.WriteLine("Invalid input: PLease enter any value");
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine("Invalid input");
            //    Console.WriteLine(e.StackTrace);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Invalid input");
            //    Console.WriteLine(ex.StackTrace);
            //}

            try
            {
                GetStudentDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Statck Trace is {0}", ex.StackTrace);  
            }
           
            
        }

        private static void GetStudentDetails()
        {
            try
            {
                Student student = new Student();
                //student.Name = "Test";
                student.GetDetails();
            }
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine("Invalid input");
            //    Console.WriteLine(ex.StackTrace);
            //}
            catch (NameNotIntializedException ex)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine(ex.StackTrace);
                //throw ex;
                throw;
            }
            finally
            {
                Console.WriteLine("Please Visit us again");
            }
        }
    }
}
