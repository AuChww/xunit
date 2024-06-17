using System;

namespace xunit.TestProject.Test{
    public static class testFunction{
        public static void test_returnTest(){
            try{
                int num = 1;
                test parameter = new test();

                string result = parameter.returnTest(num);

                if(result == "zero"){
                    Console.WriteLine("Passed : test.test_returnTest");
                }
                else{
                    Console.WriteLine("Failed : test.test_returnTest");
                }
            }
            catch(Exception ex){
                Console.WriteLine(ex);
            }
        }
    }
}