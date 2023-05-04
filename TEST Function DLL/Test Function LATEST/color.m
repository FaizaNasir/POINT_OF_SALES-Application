function FV_COLOR = color(image)

[r g b] = rgbhist(image);
r_std=std(r);
g_std=std(g);
b_std=std(b);
[O1,O2,O3] =Opponent(image);
O1_mean=mean(mean(O1));
O2_mean=mean(mean(O2));
O3_mean=std(std(O3));
O1_std=std(std(O1));
O2_std=std(std(O2));
O3_std=std(std(O3));
FV_COLOR = [r_std g_std b_std O1_mean O2_mean O3_mean O1_std O2_std O3_std];
end