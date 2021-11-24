#include <opencv2/opencv.hpp>
#include <opencv2/imgproc.hpp>
#include <stdio.h>
#include <ctime>

using namespace cv;
using namespace std;

int main() {

	//// óñòàíâëèâàåì ðóññêóþ ëîêàëü äëÿ êîíñîëè
	setlocale(LC_ALL, "Russian");

	//char filename[100]; // New_year.mp4
	//cout << "Ââåäèòå èìÿ ôàéëà, êîòîðûé õîòèòå ïðîàíàëèçèðîâàòü, è íàæìèòå Enter" << endl;
	//cin.getline(filename, 100);
	//cout << "Îòêðûò ôàéë ";
	//cout << filename << endl;

	VideoCapture vidos("Figyres.mp4");
	if (!vidos.isOpened()) cout << "Âèäåî íå íàéäåíî, ïðîâåðüòå óêàçàííûé ïóòü" << endl;

	auto fps = vidos.get(CAP_PROP_FPS); // frames per seconds
	auto delay = 1000 / fps;
	cout << "Çàäåðæêà â ìñ = " << delay << endl;

	Mat frame;

	while (1)
	{
		auto time = clock();
		vidos >> frame; //ñ÷èòàåì ôðåéì
		if (frame.channels() != 1) cvtColor(frame, frame, COLOR_RGB2GRAY);
		Mat x, y;
		Sobel(frame, x, CV_16S, 1, 0);
		Sobel(frame, y, CV_16S, 0, 1);
		// ìîäóëü ñîáåëÿ
		convertScaleAbs(x, x);
		convertScaleAbs(y, y);
		addWeighted(x, 0.5, y, 0.5, 0, frame); //ñîâìåùàåì êàðòèíêè
		imshow("sobel", frame);
		// ñêîðîñòü âèäåî
		double time_work = (clock() - time) * 1000 / CLOCKS_PER_SEC;
		if (time_work > delay - 1) time_work = 1;
		else time_work = delay - time_work;
		//  åñëè îáðàáîòêà ñîáåëåì áîëüøå ÷åì çàäåðæêà òîãäà ïîëó÷èòñÿ îòðèöàòåëüíîå çíà÷åíèå(îøèáêà)
		int vidos = waitKey(time_work);
		if (vidos >= 0) break;
	}
	destroyAllWindows();
	return 0;
}
