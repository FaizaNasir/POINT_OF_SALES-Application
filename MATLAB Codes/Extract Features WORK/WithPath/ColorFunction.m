function FV_COLOR = ColorFunction(path)
%D = dir('*.jpg');
%D = uigetdir('Select a folder');

D = dir(fullfile(path, '*.jpg'));
imcell = cell(1,numel(D)); 

for i = 1:numel(D)   
    imcell{i} = imread(strcat(path,'\',D(i).name)); 
end

for j=1:length(imcell)
a=imcell{j};
[r g b ]=rgbhist(a);% rgb histogram value
r_mean=mean(r);
g_mean=mean(g);
b_mean=mean(b);
r_std=std(r);
g_std=std(g);
b_std=std(b);
[O1,O2,O3] =Opponent(a);
O1_mean=mean(mean(O1));
O2_mean=mean(mean(O2));
O3_mean=std(std(O3));
O1_std=std(std(O1));
O2_std=std(std(O2));
O3_std=std(std(O3));

% hsv_features=hsvvalue(input);
% FV_COLOR(j,:)=[r_mean g_mean b_mean r_std g_std b_std O1_mean O2_mean  O3_mean O1_std O2_std O3_std];
FV_COLOR(j,:)=[r_std g_std b_std O1_mean O2_mean  O3_mean O1_std O2_std O3_std];

end
%save('C:\My folder\filename','varname')
save (strcat(path,'\','FV_COLOR.mat'), 'FV_COLOR')
%save FV_COLOR.mat FV_COLOR 
end
