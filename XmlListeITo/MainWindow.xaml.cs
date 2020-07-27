using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;

namespace XmlListeITo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			List<string> nekaLista = new List<string>();
			nekaLista.Add("jen");
			nekaLista.Add("dva");
			nekaLista.Add("tri");
			nekaLista.Add("cetir");
			Dictionary<string, int> recnik = new Dictionary<string, int>();
			recnik.Add("test", 2);
			XmlSerializer xmlKonvert = new XmlSerializer(nekaLista.GetType());
			StringWriter upisivac = new StringWriter();
			MemoryStream ms = new MemoryStream();
			xmlKonvert.Serialize(upisivac, nekaLista);
			string bla = upisivac.ToString();

			List<string> bla2;
			using (TextReader tr = new StringReader(bla)) 
				bla2 = xmlKonvert.Deserialize(tr) as List<string>;

			MessageBox.Show(bla2.Count.ToString());
		}
	}

	[TestClass]
	public class Testing
	{
		[TestMethod]
		public void TestM()
		{
			int x = 5;
			int y = 6;

			Assert.AreEqual(x, y);
		}
	}
}
