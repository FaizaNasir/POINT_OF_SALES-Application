function [rHist gHist bHist]=rgbhist(I)

nBins = 256;

rHist = imhist(I(:,:,1), nBins);
gHist = imhist(I(:,:,2), nBins);
bHist = imhist(I(:,:,3), nBins);
end
