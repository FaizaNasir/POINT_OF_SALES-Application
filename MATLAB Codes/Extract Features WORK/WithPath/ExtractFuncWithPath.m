function OUTPUTS = ExtractFuncWithPath(path,samples)
%path = uigetdir('Select a folder');
TotalImages  = numel(dir(fullfile(path, '*.jpg')));

ColorFunction(path);
ShapeFunction(path);
TextureFunction(path);
load(strcat(path,'\','FV_COLOR.mat'));
load(strcat(path,'\','FV_SHAPE.mat'));
load(strcat(path,'\','FV_TEXTURE.mat'));
i=1;
for a=1:samples:TotalImages
  
    temp(a:a+samples-1)=repmat(i,samples,1);
    i=i+1;
    
end
temp=temp';
%DATASET=[FV_COLOR FV_SHAPE FV_TEXTURE temp];

INPUT_FEATURES=[FV_COLOR FV_SHAPE FV_TEXTURE];
OUTPUTS = temp;

%save DATASET.mat DATASET;
%save (strcat(path,'\','FV_SHAPE.mat'), 'FV_SHAPE')
save (strcat(path,'\','INPUT_FEATURES.mat'),'INPUT_FEATURES')
save (strcat(path,'\','OUTPUTS.mat'),'OUTPUTS')
%save OUTPUTS.mat OUTPUTS;

end