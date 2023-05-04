clc;
clear all;
close all;
load('FV_COLOR.mat');
load('FV_SHAPE.mat');
load('FV_TEXTURE.mat');
    

 i=1;
for a=1:100:1000
  
    temp(a:a+99)=repmat(i,100,1);
    i=i+1;
    
end
temp=temp';
DATASET=[FV_COLOR FV_SHAPE FV_TEXTURE temp];

INPUT_FEATURES=[FV_COLOR FV_SHAPE FV_TEXTURE];
OUTPUTS = temp;

save DATASET.mat DATASET;
save INPUT_FEATURES.mat INPUT_FEATURES;
save OUTPUTS.mat OUTPUTS;

