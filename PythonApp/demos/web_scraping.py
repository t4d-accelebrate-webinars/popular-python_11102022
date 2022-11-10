import requests
import re

web_site_url = "https://finance.yahoo.com/quote/GME?p=GME&.tsrc=fin-srch"

r = re.compile(r'data-symbol="GME"(.*?)</fin-streamer>', re.MULTILINE)

response = requests.get(web_site_url)
content = response.text
matches = r.findall(content)
print(matches[0].split('>')[1])

