using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using AudioSwitcher.AudioApi.Observables;
using System.Diagnostics;

namespace SoundDeviceKeeper
{
    public partial class Form1 : Form
    {
        const string GitHubURL = "https://github.com/suwanohiro/SoundDeviceKeeper";
        const string UpdateHistoryURL = "https://github.com/suwanohiro/SoundDeviceKeeper?tab=readme-ov-file#%E6%9B%B4%E6%96%B0%E5%B1%A5%E6%AD%B4";

        /// <summary>
        /// 電源状態を示すフラグ
        /// </summary>
        private bool _isPowerOn;

        /// <summary>
        /// CoreAudioControllerのインスタンス
        /// </summary>
        private CoreAudioController _coreAudioController;

        /// <summary>
        /// 最初の既定のオーディオデバイス
        /// </summary>
        private CoreAudioDevice _defaultDevice;

        /// <summary>
        /// 現在の既定のオーディオデバイスを取得
        /// </summary>
        public CoreAudioDevice CurrentAudioDevice
        {
            get
            {
                if (_coreAudioController == null) _coreAudioController = new CoreAudioController();
                // 現在の既定デバイスを取得
                return _coreAudioController.GetDefaultDevice(DeviceType.Playback, Role.Multimedia);
            }
        }

        public Form1()
        {
            InitializeComponent();

            _isPowerOn = false;

            _coreAudioController = new CoreAudioController();
            _defaultDevice = CurrentAudioDevice;

            // 既定デバイス変更の監視
            _coreAudioController.AudioDeviceChanged.Subscribe(AudioEvent_AudioDeviceChanged);

            AudioEvent_UpdateCurrentAudioDeviceName();
            AudioEvent_UpdateDefaultAudioDeviceName();
        }

        /// <summary>
        /// オーディオデバイスの変更イベントハンドラー
        /// </summary>
        /// <param name="e">
        /// オーディオデバイスの変更に関する情報を含む引数
        /// </param>
        private void AudioEvent_AudioDeviceChanged(DeviceChangedArgs e)
        {
            AudioEvent_UpdateCurrentAudioDeviceName();

            if (!_isPowerOn) return;

            if (CurrentAudioDevice.Id != _defaultDevice.Id)
            {
                _defaultDevice.SetAsDefault();
                AudioEvent_UpdateCurrentAudioDeviceName();
            }
        }

        private void AudioEvent_UpdateCurrentAudioDeviceName()
        {
            if (CurrentAudioDeviceName.InvokeRequired)
            {
                CurrentAudioDeviceName.Invoke(() =>
                {
                    CurrentAudioDeviceName.Text = CurrentAudioDevice.FullName;
                });
            }
            else
            {
                CurrentAudioDeviceName.Text = CurrentAudioDevice.FullName;
            }
        }

        private void AudioEvent_UpdateDefaultAudioDeviceName()
        {
            if (DefaultAudioDeviceName.InvokeRequired)
            {
                DefaultAudioDeviceName.Invoke(() =>
                {
                    DefaultAudioDeviceName.Text = _defaultDevice.FullName;
                });
            }
            else
            {
                DefaultAudioDeviceName.Text = _defaultDevice.FullName;
            }
        }

        /// <summary>
        /// フォームのロードイベントハンドラー
        /// </summary>
        private void FormEvent_Form1_Load(object sender, EventArgs e)
        {
            PowerUI.BackColor = ColorData.PowerOFF.Color;
        }

        /// <summary>
        /// 電源ボタンのクリックイベントハンドラー
        /// </summary>
        private void FormEvent_Power_Click(object sender, EventArgs e)
        {
            _isPowerOn = !_isPowerOn;
            PowerUI.BackColor = _isPowerOn ? ColorData.PowerON.Color : ColorData.PowerOFF.Color;
            Power.Text = _isPowerOn ? ColorData.PowerON.Name : ColorData.PowerOFF.Name;
        }

        private void ChangeDefaultDeviceButton_Click(object sender, EventArgs e)
        {
            _defaultDevice = CurrentAudioDevice;
            AudioEvent_UpdateDefaultAudioDeviceName();
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = GitHubURL,
                UseShellExecute = true
            });
        }

        private void UpdateHistory_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = UpdateHistoryURL,
                UseShellExecute = true
            });
        }
    }
}
