function FV_TEXTURE = TextureFunction(path)
%D = dir('*.jpg');
%D = uigetdir('Select a folder');

D = dir(fullfile(path, '*.jpg'));
imcell = cell(1,numel(D)); 

for i = 1:numel(D)   
    imcell{i} = imread(strcat(path,'\',D(i).name)); 
end
for j=1:length(imcell)
input_image=imcell{j};
P=rgb2gray(input_image);
texture=statxture(P);


%input P
input(j,:)=texture;
 FV_TEXTURE(j,:)=[texture ];
end

save FV_TEXTURE.mat FV_TEXTURE



end

