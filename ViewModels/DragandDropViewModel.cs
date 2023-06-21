using System;
using System.Windows.Input;
using GesturesSample.Models;

namespace GesturesSample.ViewModels
{
	public class DragandDropViewModel: BaseViewModel
    {
		public DragandDropViewModel()
		{
			PrepareData();

        }
		public ICommand DragStartingCommand=> new Command<ImageModel>(OnDragStarted);
		public ICommand DropCommand=> new Command(onDrop);


        private ImageModel dragedImageModel {get; set;}

		private Color _frameColor=Colors.Black;
		public Color FrameColor
		{
			get
			{
				return _frameColor;
			}
			set
			{
				_frameColor = value;
				OnPropertyChanged(nameof(FrameColor));
			}
		}
		private string _draggedImage;
		public string DraggedImage
		{
			get
			{
				return _draggedImage;
			}
			set
			{
				_draggedImage = value;
				OnPropertyChanged(nameof(DraggedImage));
			}
		}

		private bool _allowDrop=true;
		public bool AllowDrop
        {
			get
			{
				return _allowDrop;
			}
			set
			{
				_allowDrop = value;
				OnPropertyChanged(nameof(AllowDrop));
			}
		}
        private List<ImageModel> _imageList;
		public List<ImageModel> ImageList
		{
			get
			{
				return _imageList;
			}
			set
			{
				_imageList = value;
				OnPropertyChanged(nameof(ImageList));
			}
		}

		private void PrepareData()
		{
			ImageList = new List<ImageModel>()
			{
				new ImageModel(){ImageSource="angry.png",ImageText="Angry"},
				new ImageModel(){ImageSource="smile.png",ImageText="Happy"},
				new ImageModel(){ImageSource="sad.png",ImageText="Sad"}
			};
		}

		private void OnDragStarted(ImageModel imageModel)
		{
			AllowDrop = true;
			DraggedImage = string.Empty;
            dragedImageModel = new ImageModel();
			dragedImageModel = imageModel;
		}

		private  void onDrop()
		{
            if (dragedImageModel?.ImageText=="Happy")
			{
				DraggedImage = dragedImageModel.ImageSource;
                FrameColor = Colors.Black;
            }
			else
			{
				AllowDrop = false;
				FrameColor = Colors.Red;
			}
		}

    }
}

