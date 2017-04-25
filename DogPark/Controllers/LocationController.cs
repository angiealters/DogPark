using DogPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DogPark.Controllers
{
    public class LocationController : ApiController
    {
        List<ParkLocations> Details = new List<ParkLocations>()
        {
            new ParkLocations {ParkName="'My Dog And Me' Park",StreetAddress="4086 County Road AB",City="Madison",State="WI",Zip=53718,ParkType="Fenced",lat=43.069109m,lng=-89.257253m},
            new ParkLocations {ParkName="Amnicon Falls State Park",StreetAddress="4279 S County Road U",City="South Range",State="WI",Zip=54874,ParkType="On Leash",lat=46.608774m,lng=-91.887415m},
            new ParkLocations {ParkName="Aztalan State Park",StreetAddress="N6200 County Road Q",City="Jefferson",State="WI",Zip=53549,ParkType="On Leash",lat=42.992225m,lng=-88.825279m},
            new ParkLocations {ParkName="Badger Prairie Dog Park",StreetAddress="6720 Highway 151",City="Verona",State="WI",Zip=53593,ParkType="Fenced",lat=42.973102m,lng=-89.520280m},
            new ParkLocations {ParkName="Best Friends Dog Park",StreetAddress="501 E County Road Y",City="Oshkosh",State="WI",Zip=54901,ParkType="Fenced",lat=44.082849m,lng=-88.533517m},
            new ParkLocations {ParkName="Big Bay State Park",StreetAddress="2402 Hagen Road",City="La Pointe",State="WI",Zip=54850,ParkType="On Leash",lat=46.787892m,lng=-90.675362m},
            new ParkLocations {ParkName="Black River State Forest",StreetAddress="W10235 Highway 12",City="Black River Falls",State="WI",Zip=54615,ParkType="On Leash",lat=44.303049m,lng=-90.620416m},
            new ParkLocations {ParkName="Blue Mound State Park",StreetAddress="4350 Mounds Park Road",City="Blue Mounds",State="WI",Zip=53517,ParkType="On Leash",lat=43.029500m,lng=-89.840698m},
            new ParkLocations {ParkName="Bong State Recreation Area",StreetAddress="26313 Burlington Road",City="Kansasville",State="WI",Zip=53139,ParkType="On Leash",lat=42.636400m,lng=-88.126598m},
            new ParkLocations {ParkName="Brittingham Dog Park",StreetAddress="326 South Broom Street",City="Madison",State="WI",Zip=53715,ParkType="Fenced",lat=43.068590m,lng=-89.385241m},
            new ParkLocations {ParkName="Brown County Dog Park",StreetAddress="1000 Pleasant Lane",City="Hobart",State="WI",Zip=54313,ParkType="Fenced",lat=44.523600m,lng=-88.134778m},
            new ParkLocations {ParkName="Browntown-Cadiz Springs State Recreation Area",StreetAddress="N2241 Cadiz Springs Road",City="Browntown",State="WI",Zip=53522,ParkType="On Leash",lat=42.583540m,lng=-89.765569m},
            new ParkLocations {ParkName="Brule River State Forest",StreetAddress="6250 Ranger Road",City="Brule",State="WI",Zip=54820,ParkType="On Leash",lat=46.539166m,lng=-91.590762m},
            new ParkLocations {ParkName="Buckhorn State Park",StreetAddress="N8450 Buckhorn Park Avenue",City="Necedah",State="WI",Zip=54646,ParkType="On Leash",lat=43.938128m,lng=-90.006557m},
            new ParkLocations {ParkName="Burlington Dog Park",StreetAddress="480 S Calumet Street",City="Burlington",State="WI",Zip=53105,ParkType="Fenced",lat=42.669668m,lng=-88.266317m},
            new ParkLocations {ParkName="Carlisle Family Dog Park",StreetAddress="4909 7th Street",City="Kenosha",State="WI",Zip=53144,ParkType="Fenced",lat=42.650485m,lng=-87.868341m},
            new ParkLocations {ParkName="Carver-Roehl Park",StreetAddress="4907 South Carvers Rock Road",City="Clinton",State="WI",Zip=53525,ParkType="On Leash",lat=42.588607m,lng=-88.830211m},
            new ParkLocations {ParkName="Chequamegon-Nicolet National Forest",StreetAddress="500 Hanson Lake Road",City="Rhinelander",State="WI",Zip=54501,ParkType="On Leash",lat=45.675482m,lng=-88.676147m},
            new ParkLocations {ParkName="Chippewa Moraine State Recreation Area",StreetAddress="13394 County Highway M",City="New Auburn",State="WI",Zip=54757,ParkType="On Leash",lat=45.219837m,lng=-91.409829m},
            new ParkLocations {ParkName="City Of Beloit Dog Park",StreetAddress="2422 Springbrook Court",City="Beloit",State="WI",Zip=53511,ParkType="Fenced",lat=42.511425m,lng=-88.996367m},
            new ParkLocations {ParkName="Copper Falls State Park",StreetAddress="36664 Copper Falls Road",City="Mellen",State="WI",Zip=54546,ParkType="On Leash",lat=46.352385m,lng=-90.643582m},
            new ParkLocations {ParkName="Currie Dog Park",StreetAddress="3535 N Mayfair Road",City="Wauwatosa",State="WI",Zip=53222,ParkType="Fenced",lat=43.082489m,lng=-88.047872m},
            new ParkLocations {ParkName="De Pere Dog Park",StreetAddress="1400 Biotech Way",City="De Pere",State="WI",Zip=54115,ParkType="Fenced",lat=44.408139m,lng=-88.109424m},
            new ParkLocations {ParkName="Demetral Dog Park",StreetAddress="601 N 6th Street",City="Madison",State="WI",Zip=53704,ParkType="Fenced",lat=43.102613m,lng=-89.357011m},
            new ParkLocations {ParkName="Devil's Lake State Park",StreetAddress="S5975 Park Road",City="Baraboo",State="WI",Zip=53913,ParkType="On Leash",lat=43.428505m,lng=-89.731334m},
            new ParkLocations {ParkName="Eau Claire Dog Park",StreetAddress="4503 House Road",City="Eau Claire",State="WI",Zip=54701,ParkType="",lat=44.769753m,lng=-91.422402m},
            new ParkLocations {ParkName="Estabrook Dog Park",StreetAddress="4400 Estabrook Drive",City="Milwaukee",State="WI",Zip=53211,ParkType="Fenced",lat=43.098479m,lng=-87.905653m},
            new ParkLocations {ParkName="FIDO Dog Park",StreetAddress="Satterlee Street",City="Fond du Lac",State="WI",Zip=54935,ParkType="Fenced",lat=43.782614m,lng=-88.457510m},
            new ParkLocations {ParkName="Flambeau River State Forest",StreetAddress="W1613 County Road W",City="Winter",State="WI",Zip=54896,ParkType="On Leash",lat=45.772318m,lng=-90.762298m},
            new ParkLocations {ParkName="Governor Dodge State Park",StreetAddress="4175 Wisconsin 23",City="Dodgeville",State="WI",Zip=53533,ParkType="On Leash",lat=43.020658m,lng=-90.142188m},
            new ParkLocations {ParkName="Governor Knowles State Forest",StreetAddress="325 WI-70",City="Grantsburg",State="WI",Zip=54840,ParkType="On Leash",lat=45.773149m,lng=-92.776319m},
            new ParkLocations {ParkName="Governor Nelson State Park",StreetAddress="5140 County Highway M",City="Waunakee",State="WI",Zip=53597,ParkType="On Leash(Unless in pet swim area)",lat=43.128661m,lng=-89.442050m},
            new ParkLocations {ParkName="Granville Dog Park",StreetAddress="11718 Good Hope Road",City="Milwaukee",State="WI",Zip=53224,ParkType="Not Fenced",lat=43.149673m,lng=-88.058338m},
            new ParkLocations {ParkName="Happy Tails Dog Park",StreetAddress="841 Chippewa Crossing Boulevard",City="Chippewa Falls",State="WI",Zip=54729,ParkType="Fenced",lat=44.916052m,lng=-91.372857m},
            new ParkLocations {ParkName="Harrington Beach State Park",StreetAddress="531 County Road D",City="Belgium",State="WI",Zip=53004,ParkType="On Leash",lat=43.492876m,lng=-87.803664m},
            new ParkLocations {ParkName="Hartman Creek State Park",StreetAddress="Hartman Creek Road",City="Waupaca",State="WI",Zip=54981,ParkType="On Leash",lat=44.328771m,lng=-89.216385m},
            new ParkLocations {ParkName="High Cliff State Park",StreetAddress="High Cliff State Park Road",City="Hilbert",State="WI",Zip=54129,ParkType="On Leash",lat=44.155043m,lng=-88.290777m},
            new ParkLocations {ParkName="Houska Dog Park",StreetAddress="1011 Joseph Houska Drive",City="La Crosse",State="WI",Zip=54601,ParkType="Fenced",lat=43.802819m,lng=-91.257656m},
            new ParkLocations {ParkName="Independence Dog Park",StreetAddress="700 S Wilson Avenue",City="Hartford",State="WI",Zip=53027,ParkType="Fenced",lat=43.300437m,lng=-88.369174m},
            new ParkLocations {ParkName="Indian Creek Dog Run",StreetAddress="North 8th Street and Albert Drive",City="Manitowoc",State="WI",Zip=54220,ParkType="Not Fenced",lat=44.122028m,lng=-87.655110m},
            new ParkLocations {ParkName="Indian Lake Dog Park",StreetAddress="8183 WI-19",City="Cross Plains",State="WI",Zip=53528,ParkType="Not Fenced",lat=43.185611m,lng=-89.622535m},
            new ParkLocations {ParkName="Interstate State Park",StreetAddress="WI-35",City="St Croix Falls",State="WI",Zip=54024,ParkType="On Leash",lat=45.388888m,lng=-92.654893m},
            new ParkLocations {ParkName="Johnson Dog Park",StreetAddress="4649 Wisconsin 38 Trunk",City="Racine",State="WI",Zip=53405,ParkType="Not Fenced",lat=42.779787m,lng=-87.866485m},
            new ParkLocations {ParkName="Karen A. Nelson Memorial Dog Park",StreetAddress="3800 Northwestern Avenue",City="Racine",State="WI",Zip=53404,ParkType="Fenced",lat=42.749392m,lng=-87.821059m},
            new ParkLocations {ParkName="Katherine K. Carpenter Dog Park",StreetAddress="801 W Zedler Lane",City="Mequon",State="WI",Zip=53092,ParkType="Not Fenced",lat=43.197621m,lng=-87.919400m},
            new ParkLocations {ParkName="Kaukauna Dog Park",StreetAddress="310 Farmland Court",City="Kaukauna",State="WI",Zip=54130,ParkType="Fenced",lat=44.302776m,lng=-88.243707m},
            new ParkLocations {ParkName="Kettle Moraine State Forest",StreetAddress="N1765 County Road G",City="Campbellsport",State="WI",Zip=53010,ParkType="On Leash",lat=43.607307m,lng=-88.189487m},
            new ParkLocations {ParkName="Kinnickinnic State Park",StreetAddress="County Road F",City="River Falls",State="WI",Zip=54022,ParkType="On Leash",lat=44.831617m,lng=-92.733257m},
            new ParkLocations {ParkName="Kohler-Andrae State Park",StreetAddress="1020 Beach Park Lane",City="Sheboygan",State="WI",Zip=53081,ParkType="On Leash",lat=43.665016m,lng=-87.719736m},
            new ParkLocations {ParkName="Kronenwetter Bark Park",StreetAddress="2350 Sunny Meadow Drive",City="Kronewetter",State="WI",Zip=54455,ParkType="Fenced",lat=44.841873m,lng=-89.596853m},
            new ParkLocations {ParkName="Ladysmith Dog Park",StreetAddress="E 3rd Street S and Phillips Avenue E",City="Ladysmith",State="WI",Zip=54848,ParkType="Fenced",lat=45.454088m,lng=-91.099271m},
            new ParkLocations {ParkName="Lake Kegonsa State Park",StreetAddress="2405 Door Creek Road",City="Stoughton",State="WI",Zip=53589,ParkType="On Leash(Unless in pet swim area)",lat=42.979851m,lng=-89.233322m},
            new ParkLocations {ParkName="Lake Wissota State Park",StreetAddress="18127 County Highway O",City="Chippewa Falls",State="WI",Zip=54729,ParkType="On Leash",lat=44.980865m,lng=-91.304962m},
            new ParkLocations {ParkName="Lakeside Dog Park",StreetAddress="555 N Park Avenue",City="Fond du Lac",State="WI",Zip=54935,ParkType="Fenced",lat=43.796629m,lng=-88.439276m},
            new ParkLocations {ParkName="Mac Arthur Dog Run",StreetAddress="3001 Mac Arthur Road",City="Waukesha",State="WI",Zip=53188,ParkType="Unfenced",lat=42.996416m,lng=-88.281938m},
            new ParkLocations {ParkName="Marina Retention Area Dog Park",StreetAddress="Maritime Drive",City="Manitowoc",State="WI",Zip=54220,ParkType="Fenced",lat=44.095977m,lng=-87.650084m},
            new ParkLocations {ParkName="McCormick Dog Park",StreetAddress="709 McCormick Avenue",City="Madison",State="WI",Zip=53704,ParkType="Fenced",lat=43.107829m,lng=-89.340719m},
            new ParkLocations {ParkName="Menomonie Dog Park",StreetAddress="Brickyard Road",City="Menomonie",State="WI",Zip=54751,ParkType="Fenced",lat=44.881195m,lng=-91.939543m},
            new ParkLocations {ParkName="Merrick State Park",StreetAddress="S2965 WI-35",City="Fountain City",State="WI",Zip=54629,ParkType="On Leash",lat=44.155246m,lng=-91.754143m},
            new ParkLocations {ParkName="MRD Dog Exercise Area",StreetAddress="5209 County Highway Q",City="Middleton",State="WI",Zip=53562,ParkType="Fenced",lat=43.141434m,lng=-89.480714m},
            new ParkLocations {ParkName="Mill Bluff State Park",StreetAddress="15819 Funnel Road",City="Camp Douglas",State="WI",Zip=54618,ParkType="On Leash",lat=43.956387m,lng=-90.318882m},
            new ParkLocations {ParkName="Mineral Point Unleashed",StreetAddress="3000 Business Park Road",City="Mineral Point",State="WI",Zip=53565,ParkType="Fenced",lat=42.882619m,lng=-90.160546m},
            new ParkLocations {ParkName="Minooka Dog Park",StreetAddress="1927 E Sunset Drive",City="Waukesha",State="WI",Zip=53186,ParkType="Fenced",lat=42.987615m,lng=-88.195457m},
            new ParkLocations {ParkName="Mirror Lake State Park",StreetAddress="E10320 Fern Dell Road",City="Baraboo",State="WI",Zip=53913,ParkType="On Leash",lat=43.561922m,lng=-89.807997m},
            new ParkLocations {ParkName="Mitchell Park",StreetAddress="19900 River Road",City="Brookfield",State="WI",Zip=53045,ParkType="Not Fenced",lat=43.076647m,lng=-88.159125m},
            new ParkLocations {ParkName="Muttland Meadows",StreetAddress="789 S Green Bay Road",City="Grafton",State="WI",Zip=53024,ParkType="Fenced",lat=43.306162m,lng=-87.957079m},
            new ParkLocations {ParkName="Myrick Dog Park",StreetAddress="2000 La Crosse Street",City="La Crosse",State="WI",Zip=54601,ParkType="Fenced",lat=43.821059m,lng=-91.225662m},
            new ParkLocations {ParkName="Nashotah Dog Park",StreetAddress="W330 N5113 County Road C",City="Nashotah",State="WI",Zip=53058,ParkType="Fenced",lat=43.109563m,lng=-88.402788m},
            new ParkLocations {ParkName="Natural Bridge State Park",StreetAddress="E7992",City="North Freedom",State="WI",Zip=53951,ParkType="On Leash",lat=43.346357m,lng=-89.932344m},
            new ParkLocations {ParkName="New Glarus Woods State Park",StreetAddress="W5446 County Highway Nn",City="New Glarus",State="WI",Zip=53574,ParkType="On Leash",lat=42.787827m,lng=-89.634233m},
            new ParkLocations {ParkName="New Richmond Dog Park",StreetAddress="185th Avenue",City="New Richmond",State="WI",Zip=54017,ParkType="Fenced",lat=45.129197m,lng=-92.579985m},
            new ParkLocations {ParkName="Newport State Park",StreetAddress="475 County Road NP",City="Ellison Bay",State="WI",Zip=54210,ParkType="On Leash",lat=45.236399m,lng=-86.996784m},
            new ParkLocations {ParkName="NL Jaycees Dog Park",StreetAddress="740 River Road",City="New London",State="WI",Zip=54961,ParkType="Fenced",lat=44.400184m,lng=-88.737323m},
            new ParkLocations {ParkName="North Highland-American Legion State Forest",StreetAddress="4125 County Highway M",City="Boulder Junction",State="WI",Zip=54512,ParkType="On Leash",lat=45.798090m,lng=-89.430166m},
            new ParkLocations {ParkName="Our Bark Park",StreetAddress="2711 Eaton Lane",City="Racine",State="WI",Zip=53404,ParkType="Private",lat=42.753506m,lng=-87.812531m},
            new ParkLocations {ParkName="Outagamie County Dog Park",StreetAddress="2830 French Road",City="Appleton",State="WI",Zip=54911,ParkType="Fenced",lat=44.287762m,lng=-88.351493m},
            new ParkLocations {ParkName="Palmer Park Off Leash Dog Area",StreetAddress="2501 Palmer Drive",City="Janesville",State="WI",Zip=53545,ParkType="Not Fenced",lat=42.676220m,lng=-88.992573m},
            new ParkLocations {ParkName="Pattison State Park",StreetAddress="6294 WI-35",City="Superior",State="WI",Zip=54880,ParkType="On Leash",lat=46.536660m,lng=-92.116798m},
            new ParkLocations {ParkName="Paw Print Park",StreetAddress="N4238421 W08902427",City="Janesville",State="WI",Zip=53546,ParkType="Fenced",lat=42.640241m,lng=-89.040520m},
            new ParkLocations {ParkName="Paws 'N Play Dog Park",StreetAddress="E 21st Street and S Peach Avenue",City="Marshfield",State="WI",Zip=54449,ParkType="Fenced",lat=44.649401m,lng=-90.172308m},
            new ParkLocations {ParkName="Peninsula State Park",StreetAddress="9462 Shore Road",City="Fish Creek",State="WI",Zip=54212,ParkType="On Leash",lat=45.128476m,lng=-87.237138m},
            new ParkLocations {ParkName="Perrot State Park",StreetAddress="26247 Sullivan Road",City="Trempealeau",State="WI",Zip=54661,ParkType="On Leash",lat=44.016089m,lng=-91.465473m},
            new ParkLocations {ParkName="Pike Lake State Park",StreetAddress="3544 Kettle Moraine Road",City="Hartford",State="WI",Zip=53027,ParkType="On Leash",lat=43.319557m,lng=-88.319064m},
            new ParkLocations {ParkName="Point Beach State Forest",StreetAddress="9400 County Road O",City="Two Rivers",State="WI",Zip=54241,ParkType="On Leash",lat=44.195559m,lng=-87.517948m},
            new ParkLocations {ParkName="Potawatomi State Park",StreetAddress="3740 Park Drive",City="Sturgeon Bay",State="WI",Zip=54235,ParkType="On Leash",lat=44.851920m,lng=-87.425323m},
            new ParkLocations {ParkName="Prairie Moraine Parkway Dog Park",StreetAddress="1970 County Highway PB",City="Verona",State="WI",Zip=53593,ParkType="Fenced",lat=42.962029m,lng=-89.513394m},
            new ParkLocations {ParkName="Price Park Dog Park",StreetAddress="N6499 Hodunk Road",City="Elkhorn",State="WI",Zip=53121,ParkType="Fenced",lat=42.724561m,lng=-88.470830m},
            new ParkLocations {ParkName="Quann Dog Park",StreetAddress="1802 Quann-Olin Parkway",City="Madison",State="WI",Zip=53713,ParkType="Fenced",lat=43.048953m,lng=-89.385746m},
            new ParkLocations {ParkName="Rib Mountain State Park",StreetAddress="4200 Park Road",City="Wausau",State="WI",Zip=54401,ParkType="On Leash",lat=44.921581m,lng=-89.688221m},
            new ParkLocations {ParkName="Ripon Dog Park",StreetAddress="N8863 S Koro Road",City="Ripon",State="WI",Zip=54971,ParkType="Fenced",lat=43.864888m,lng=-88.871284m},
            new ParkLocations {ParkName="Ripp Dog Park",StreetAddress="213 Dorn Drive",City="Waunakee",State="WI",Zip=53597,ParkType="Fenced",lat=43.188516m,lng=-89.472098m},
            new ParkLocations {ParkName="Roche-A-Cri State Park",StreetAddress="1767 State Highway 13",City="Friendship",State="WI",Zip=53934,ParkType="On Leash",lat=44.000936m,lng=-89.812313m},
            new ParkLocations {ParkName="Rock Island State Park",StreetAddress="1924 Indian Point Road",City="Washington",State="WI",Zip=54246,ParkType="On Leash",lat=45.409538m,lng=-86.829071m},
            new ParkLocations {ParkName="Rock River Parkway Off Leash Area",StreetAddress="S County Road D and W Rockport Park Drive",City="Janesville",State="WI",Zip=53548,ParkType="Not Fenced",lat=42.661103m,lng=-89.059577m},
            new ParkLocations {ParkName="Rocky Arbor State Park",StreetAddress="Highway 12",City="Wisconsin Dells",State="WI",Zip=53965,ParkType="On Leash",lat=43.641945m,lng=-89.805851m},
            new ParkLocations {ParkName="Room to Roam Dog Park",StreetAddress="1351 Apache Avenue",City="Nekoosa",State="WI",Zip=54457,ParkType="Fenced",lat=44.195482m,lng=-89.830463m},
            new ParkLocations {ParkName="Roverwest Dog Exercise Area",StreetAddress="3299 N Weil Street",City="Milwaukee",State="WI",Zip=53212,ParkType="Fenced",lat=43.078326m,lng=-87.898962m},
            new ParkLocations {ParkName="Runway Dog Park",StreetAddress="1214 E Rawson Avenue",City="Oak Creek",State="WI",Zip=53154,ParkType="Fenced",lat=42.920811m,lng=-87.900839m},
            new ParkLocations {ParkName="Salem Dog Park (at Old Settlers Park)",StreetAddress="24100 75th St",City="Salem",State="WI",Zip=53168,ParkType="Fenced",lat=42.568353m,lng=-88.101158m},
            new ParkLocations {ParkName="Shamrock Dog Park",StreetAddress="E11340 County Rd PF",City="Prairie du Sac",State="WI",Zip=53578,ParkType="Fenced",lat=43.293770m,lng=-89.757266m},
            new ParkLocations {ParkName="Spring Green Dog Park",StreetAddress="201 Shifflet Rd",City="Spring Green",State="WI",Zip=53588,ParkType="Fenced",lat=43.168002m,lng=-90.079015m},
            new ParkLocations {ParkName="Sister Bay Dog Park (at Community Garden)",StreetAddress="2155 Autumn Court",City="Sister Bay",State="WI",Zip=54234,ParkType="Fenced",lat=45.188227m,lng=-87.107555m},
            new ParkLocations {ParkName="St. Croix National Scenic Riverway",StreetAddress="401 N Hamilton St",City="St. Croix",State="WI",Zip=54024,ParkType="On Leash",lat=45.416196m,lng=-92.646804m},
            new ParkLocations {ParkName="St. Francis Seminary Woods",StreetAddress="2479 North Murray Avenue",City="Milwaukee",State="WI",Zip=53211,ParkType="On Leash",lat=43.063319m,lng=-87.885566m},
            new ParkLocations {ParkName="Standing Rocks Dog Park",StreetAddress="7695 Standing Rocks Rd",City="Stevens Point",State="WI",Zip=54481,ParkType="Fenced",lat=44.432900m,lng=-89.398200m},
            new ParkLocations {ParkName="Stevens Point Dog Park",StreetAddress="601 Mason St",City="Stevens Point",State="WI",Zip=54481,ParkType="Fenced",lat=44.509697m,lng=-89.581060m},
            new ParkLocations {ParkName="Sun Prairie Dog Park",StreetAddress="1025 S Bird St",City="Sun Prairie",State="WI",Zip=53590,ParkType="Fenced",lat=43.166936m,lng=-89.225789m},
            new ParkLocations {ParkName="Sycamore Dog Park",StreetAddress="4517 Sycamore Park",City="Madison",State="WI",Zip=53714,ParkType="Fenced",lat=43.111855m,lng=-89.302121m},
            new ParkLocations {ParkName="Tails n Trails Dog Park - Milton",StreetAddress="466 Elm St",City="Milton",State="WI",Zip=53563,ParkType="Fenced",lat=42.773594m,lng=-88.965311m},
            new ParkLocations {ParkName="Terri Tinsley Dog Park (at Bicentennial Park)",StreetAddress="W5098 Canine Dr",City="Johnson Creek",State="WI",Zip=53038,ParkType="Fenced",lat=43.056005m,lng=-88.787879m},
            new ParkLocations {ParkName="Token Creek Dog Park",StreetAddress="6200 US Hwy 51",City="Madison",State="WI",Zip=53532,ParkType="On Leash",lat=43.184614m,lng=-89.320817m},
            new ParkLocations {ParkName="Tomahawk Dog Park",StreetAddress="W Somo Ave",City="Tomahawk",State="WI",Zip=54487,ParkType="Fenced",lat=45.472095m,lng=-89.737716m},
            new ParkLocations {ParkName="Van Riper Dog Park",StreetAddress="1311 Van Riper Road",City="Onalaska",State="WI",Zip=54650,ParkType="Fenced",lat=43.903397m,lng=-91.241423m},
            new ParkLocations {ParkName="Viking Dog Park",StreetAddress="2525 County Hwy B",City="Stoughton",State="WI",Zip=53589,ParkType="Fenced",lat=42.968745m,lng=-89.284255m},
            new ParkLocations {ParkName="Warner Dog Park",StreetAddress="2301 Sheridan Dr",City="Madison",State="WI",Zip=53704,ParkType="Fenced",lat=43.125729m,lng=-89.374419m},
            new ParkLocations {ParkName="Warnimont Dog Park",StreetAddress="5400 S. Lake Dr",City="Cudahy",State="WI",Zip=53110,ParkType="Fenced",lat=42.947737m,lng=-87.846678m},
            new ParkLocations {ParkName="Warren Close Bark Park (at KD Park)",StreetAddress="35610 89th St",City="Twin Lakes,",State="WI",Zip=53181,ParkType="Fenced",lat=42.549947m,lng=-88.242274m},
            new ParkLocations {ParkName="Waupaca County Dog Park",StreetAddress="601 Hwy K",City="Waupaca",State="Wi",Zip=54981,ParkType="Fenced",lat=44.357895m,lng=-89.079198m},
            new ParkLocations {ParkName="Waupun Dog Park",StreetAddress="901 N. Madison St",City="Waupun",State="WI",Zip=53963,ParkType="Fenced",lat=43.646252m,lng=-88.728917m},
            new ParkLocations {ParkName="West Bend Dog Park",StreetAddress="1150 18th Ave",City="West Bend",State="WI",Zip=53095,ParkType="Fenced",lat=43.389862m,lng=-88.200880m},
            new ParkLocations {ParkName="Weston Dog Park",StreetAddress="6100 Rogan Ln",City="Schofield",State="WI",Zip=54476,ParkType="Fenced",lat=44.911170m,lng=-89.543884m},
            new ParkLocations {ParkName="White River Dog Park",StreetAddress="Sage Street and Waverly Street",City="Lake Geneva",State="WI",Zip=53147,ParkType="Fenced",lat=42.595025m,lng=-88.430539m},
            new ParkLocations {ParkName="Whitefish Dunes State Park",StreetAddress="3275 Clarks Lake Rd",City="Sturgeon Bay",State="WI",Zip=54235,ParkType="On Leash",lat=44.927950m,lng=-87.185189m},
            new ParkLocations {ParkName="Whitewater Bark Park (at Moraine View Park)",StreetAddress="933 Commercial Ave",City="Whitewater",State="WI",Zip=53190,ParkType="Fenced",lat=42.836511m,lng=-88.711956m},
            new ParkLocations {ParkName="Whitewater Natureland Park",StreetAddress="W8338 Territorial Rd",City="Whitewater",State="WI",Zip=53190,ParkType="On Leash",lat=42.743230m,lng=-88.715286m},
            new ParkLocations {ParkName="Wildcat Mountain State Park",StreetAddress="E13660 Hwy 33",City="Ontario",State="WI",Zip=54651,ParkType="On Leash",lat=43.701875m,lng=-90.570685m},
            new ParkLocations {ParkName="Willow River State Park",StreetAddress="1034 County Hwy A",City="Hudson",State="WI",Zip=54016,ParkType="On Leash",lat=45.012974m,lng=-92.675465m},
            new ParkLocations {ParkName="Yahara Heights Dog Park (or Cherokee Marsh)",StreetAddress="5428 WI-113",City="Waunakee",State="WI",Zip=53597,ParkType="Fenced",lat=43.192035m,lng=-89.441751m},
            new ParkLocations {ParkName="Zander Dog Park",StreetAddress="1406 Parkway Blvd",City="Two Rivers",State="WI",Zip=54241,ParkType="Fenced",lat=44.145999m,lng=-87.587553m},         

            //new ParkLocations {ParkName="",StreetAddress="",City="",State="",Zip=,ParkType="",lat=m,lng=m},
        };
        [HttpGet]

        //GET api/location
        public IEnumerable<ParkLocations> Get()
        {
            return Details;
        }

        //GET api/location/1
        public ParkLocations Get(string park)
        {
            var name = Details.SingleOrDefault(p => p.ParkName == park);

            if (name == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return name;
        }

        //POST api/location
        [HttpPost]
        public ParkLocations CreateParkLocation(ParkLocations park)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            Details.Add(park);

            return park;
        }

        //PUT api/location/1
        [HttpPut]
        public void UpdatePark(string park, ParkLocations location)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var parkLocation = Details.SingleOrDefault(p => p.ParkName == park);

            if (parkLocation == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            parkLocation.ParkName = location.ParkName;
            parkLocation.StreetAddress = location.StreetAddress;
            parkLocation.City = location.City;
            parkLocation.State = location.State;
            parkLocation.Zip = location.Zip;
            parkLocation.ParkType = location.ParkType;
            parkLocation.lat = location.lat;
            parkLocation.lng = location.lng;
        }

        //DELETE api/location/1
        [HttpDelete]
        public void DeleteLocation(string park)
        {
            var parkLocation = Details.SingleOrDefault(p => p.ParkName == park);

            if (parkLocation == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Details.Remove(parkLocation);
        }
    }
}
