function DATASET = ExtractFeaturesFunc(path,samples)
%path = uigetdir('Select a folder');
TotalImages  = numel(dir(fullfile(path, '*.jpg')));

ColorFunction(path);
ShapeFunction(path);
TextureFunction(path);
load('FV_COLOR.mat');
load('FV_SHAPE.mat');
load('FV_TEXTURE.mat');
i=1;
for a=1:samples:TotalImages
  
    temp(a:a+samples-1)=repmat(i,samples,1);
    i=i+1;
    
end
temp=temp';
DATASET=[FV_COLOR FV_SHAPE FV_TEXTURE temp];

INPUT_FEATURES=[FV_COLOR FV_SHAPE FV_TEXTURE];
OUTPUTS = temp;

%save DATASET.mat DATASET;
save INPUT_FEATURES.mat INPUT_FEATURES;
save OUTPUTS.mat OUTPUTS;

end