function FV_SHAPE = shape(image)

I=im2bw(image);
stats=regionprops(I,'all'); % extract regions

selected_area=[stats.Area]; % select all area to variable
[val index]=max(selected_area); % find max area from all regions
Area=[stats(index,1).Area];
Centroid=[stats(index,1).Centroid];
BoundingBox=[stats(index,1).BoundingBox];
MajorAxisLength=[stats(index,1).MajorAxisLength];
MinorAxisLength=[stats(index,1).MinorAxisLength];
Eccentricity=[stats(index,1).Eccentricity];
Orientation=[stats(index,1).Orientation];
%ConvexHull=[stats(index,1).ConvexHull];
%ConvexImage=[stats(index,1).ConvexImage];
ConvexArea=[stats(index,1).ConvexArea];
%Image=[stats(index,1).Image];
%FilledImage=[stats(index,1).FilledImage];
FilledArea=[stats(index,1).FilledArea];
EulerNumber=[stats(index,1).EulerNumber];
%Extrema=[stats(index,1).Extrema];
EquivDiameter=[stats(index,1).EquivDiameter];
Solidity=[stats(index,1).Solidity];
Extent=[stats(index,1).Extent];
%PixelIdxList=[stats(index,1).PixelIdxList];
%PixelList=[stats(index,1).PixelList];
Perimeter=[stats(index,1).Perimeter];
%FV_SHAPE =[Area Centroid(1,1) Centroid(1,2) BoundingBox(1,1) BoundingBox(1,3) MajorAxisLength MinorAxisLength Eccentricity Orientation ConvexArea FilledArea EulerNumber EquivDiameter Solidity Extent Perimeter];
%FV_SHAPE=[Area Centroid(1,1) Centroid(1,2) MajorAxisLength MinorAxisLength Eccentricity Orientation EulerNumber EquivDiameter Solidity];
FV_SHAPE = [Area Centroid(1,1) Centroid(1,2) BoundingBox(1,3) MajorAxisLength MinorAxisLength Eccentricity Orientation ConvexArea FilledArea EulerNumber EquivDiameter Solidity Extent Perimeter];
end