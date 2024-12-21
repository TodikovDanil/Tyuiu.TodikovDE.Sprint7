using Tyuiu.TodikovDE.Sprint7.Tsak0.V14.Lib;
namespace Tyuiu.TodikovDE.Sprint7.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidParse()
        {
            DataService dataService = new DataService();

            List<string[]> routes = dataService.ParseRouteItems(@"test.csv");
            List<string[]> routesWait = new List<string[]>
            {
                {new string[]{"1","�����������|������� ��� �62|����� ������� ��������|��������������|�������|�����������|��������|�����������|��������� �����|��������|�������������|����� �����������|��������� ��� �2|����� �37|���������|�����������|������� ��������|����� ��. �������|��. �����������|������������|����������|����� ����� �����|��������� ���������|��������|������������� ��������� �������|�����������|����� �73","�������","10:30 | 10:33 | 09:57 | 09:57 | 10:00 | 10:02 | 10:03 | 10:05 | 10:08 | 10:10 | 10:12 | 10:15 | 10:17 | 10:18 | 10:21 | 10:23 | 1 | 4 | 6 | 8 | 10 | 13 | 14 | 16 | 17 | 18 | 10:19" } },
                {new string[]{"62","����� �63|��������� ����������|�����������|����� ���������� ����|������ ���������� ������","���������/�������","10|10|15|17|20","true"} }
            };
            CollectionAssert.Equals(routes, routesWait);
        }
    }
}