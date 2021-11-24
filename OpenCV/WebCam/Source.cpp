#include <opencv2/opencv.hpp>
#include <iostream>

using namespace cv;
using namespace std;

int main(int argc, char* argv[])
{
	
	VideoCapture cap(1);

	
	if (cap.isOpened() == false)
	{
		cout << "Cannot open the video camera" << endl;
		cin.get(); 
		return -1;
	}

	double dWidth = cap.get(CAP_PROP_FRAME_WIDTH); 
	double dHeight = cap.get(CAP_PROP_FRAME_HEIGHT);

	cout << "Resolution of the video : " << dWidth << " x " << dHeight << endl;

	string window_name = "My Camera Feed";
	namedWindow(window_name);
	auto fps = cap.get(CAP_PROP_FPS); 
	auto delay = 1000 / fps;
	cout << "Çàäåðæêà â ìñ = " << delay << endl;
	while (true)
	{
		Mat frame;
		bool bSuccess = cap.read(frame); 


		if (bSuccess == false)
		{
			cout << "Video camera is disconnected" << endl;
			cin.get(); 
		break;
		}

		auto time = clock();
	
		imshow(window_name, frame);
		if (frame.channels() != 1) cvtColor(frame, frame, COLOR_RGB2GRAY);
		Mat x, y;
		Sobel(frame, x, CV_16S, 1, 0);
		Sobel(frame, y, CV_16S, 0, 1);
		// ìîäóëü ñîáåëÿ
		convertScaleAbs(x, x);
		convertScaleAbs(y, y);
		addWeighted(x, 0.5, y, 0.5, 0, frame); 
		imshow("sobel", frame);
		
		double time_work = (clock() - time) * 1000 / CLOCKS_PER_SEC;
		if (time_work > delay - 1) time_work = 1;
		else time_work = delay - time_work;

		if (waitKey(10) == 27)
		{
		cout << "Esc key is pressed by user. Stoppig the video" << endl;
		break;
		}
	}
