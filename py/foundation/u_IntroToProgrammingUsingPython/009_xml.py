import sys
from xml.dom.minidom import parse
import xml.dom.minidom

# =============================================================================
# Create input xml file
# =============================================================================
try:
    f = open('009_data.xml', 'w')
    f.write('<?xml version="1.0" encoding="UTF-8"?>\r')
    f.write('<stocks>\r')
    
    f.write('\t<stock symbol="fb">\r')
    f.write('\t\t<open>213</open>\r')
    f.write('\t\t<high>216.24</high>\r')
    f.write('\t\t<low>212.61</low>\r')
    f.write('\t\t<close>215.22</close>\r')
    f.write('\t</stock>\r')
    
    f.write('\t<stock symbol="aapl">\r')
    f.write('\t\t<open>297.16</open>\r')
    f.write('\t\t<high>304.44</high>\r')
    f.write('\t\t<low>297.16</low>\r')
    f.write('\t\t<close>303.19</close>\r')
    f.write('\t</stock>\r')

    f.write('\t<stock symbol="amzn">\r')
    f.write('\t\t<open>1898.04</open>\r')
    f.write('\t\t<high>1911.00</high>\r')
    f.write('\t\t<low>1886.44</low>\r')
    f.write('\t\t<close>1891.97</close>\r')
    f.write('\t</stock>\r')

    f.write('\t<stock symbol="nflx">\r')
    f.write('\t\t<open>331.49</open>\r')
    f.write('\t\t<high>342.70</high>\r')
    f.write('\t\t<low>331.05</low>\r')
    f.write('\t\t<close>339.26</close>\r')
    f.write('\t</stock>\r')

    f.write('\t<stock symbol="goog">\r')
    f.write('\t\t<open>1394.82</open>\r')
    f.write('\t\t<high>1411.85</high>\r')
    f.write('\t\t<low>1392.63</low>\r')
    f.write('\t\t<close>1405.04</close>\r')
    f.write('\t</stock>\r')

    f.write('\t<stock symbol="msft">\r')
    f.write('\t\t<open>158.93</open>\r')
    f.write('\t\t<high>160.80</high>\r')
    f.write('\t\t<low>157.95</low>\r')
    f.write('\t\t<close>160.09</close>\r')
    f.write('\t</stock>\r')
    
    f.write('</stocks>\r')
    f.close()
except:
    print(sys.exc_info()[0])

# =============================================================================
# Parse xml
# =============================================================================
try:
    domtree = xml.dom.minidom.parse("009_data.xml")

    collection = domtree.documentElement

    stocks = collection.getElementsByTagName("stock")

    for stock in stocks:
        if stock.hasAttribute("symbol"):
            print("symbol: %s" % stock.getAttribute("symbol"))
except:
    print(sys.exc_info()[0])
