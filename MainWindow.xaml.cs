using System;
using System.Windows;
using System.Windows.Threading;

namespace GameChronometer
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer = null!;
        private TimeSpan _elapsed;
        private bool _isRunning;

        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
            MouseLeftButtonDown += (s, e) => DragMove();
        }
        
        private void InitializeTimer()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(1000);
            _timer.Tick += Timer_Tick;
            _elapsed = TimeSpan.Zero;
            _isRunning = false;
        }
        
        private void Timer_Tick(object? sender, EventArgs e)
        {
            _elapsed = _elapsed.Add(TimeSpan.FromSeconds(1));
            TimeDisplay.Text = _elapsed.ToString(@"hh\:mm\:ss");
        }

        private void PlayPauseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_isRunning)
            {
                _timer.Stop();
                PlayPauseBtn.Content = "Play";
                _isRunning = false;
            }
            else
            {
                _timer.Start();
                PlayPauseBtn.Content = "Pause";
                _isRunning = true;
            }            
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            _elapsed = TimeSpan.Zero;
            TimeDisplay.Text = "00:00:00";
            PlayPauseBtn.Content = "Play";
            _isRunning = false;
        }
    }
}