cd /d "C:\Users\mcsnavin\Pictures\MF-33 Register font\Train"
"C:\Program Files (x86)\Tesseract-OCR\tesseract" mit.tif mit --psm 7 box.train

echo Compute the Character Set..
"C:\Program Files (x86)\Tesseract-OCR\unicharset_extractor.exe" mit.box
"C:\Program Files (x86)\Tesseract-OCR\set_unicharset_properties" -U unicharset -O unicharset --script_dir=%~dp0
"C:\Program Files (x86)\Tesseract-OCR\shapeclustering" -F "C:\Program Files (x86)\Tesseract-OCR\font_properties" -U unicharset -O mit.unicharset mit.tr
"C:\Program Files (x86)\Tesseract-OCR\mftraining" -F "C:\Program Files (x86)\Tesseract-OCR\font_properties" -U unicharset -O mit.unicharset mit.tr

echo Clustering.. 
"C:\Program Files (x86)\Tesseract-OCR\cntraining.exe" mit.tr

echo Delete Existing Files..
del mit.normproto
del mit.inttemp
del mit.pffmtable
del mit.shapetable

echo Rename Files..
rename normproto mit.normproto
rename inttemp mit.inttemp
rename pffmtable mit.pffmtable
rename shapetable mit.shapetable

echo Create Tessdata..
"C:\Program Files (x86)\Tesseract-OCR\combine_tessdata.exe" mit.
