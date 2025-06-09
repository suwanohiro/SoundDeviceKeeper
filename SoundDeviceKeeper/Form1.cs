using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using AudioSwitcher.AudioApi.Observables;

namespace SoundDeviceKeeper
{
    public partial class Form1 : Form
    {
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
        private CoreAudioDevice _initialDefaultDevice;

        /// <summary>
        /// オーディオデバイスの変更を監視するためのサブスクリプション
        /// </summary>
        IDisposable _audioChangeSubscription;

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
            _initialDefaultDevice = CurrentAudioDevice;

            // 既定デバイス変更の監視
            _audioChangeSubscription = _coreAudioController.AudioDeviceChanged.Subscribe(AudioEvent_AudioDeviceChanged);
        }

        /// <summary>
        /// オーディオデバイスの変更イベントハンドラー
        /// </summary>
        /// <param name="e">
        /// オーディオデバイスの変更に関する情報を含む引数
        /// </param>
        private void AudioEvent_AudioDeviceChanged(DeviceChangedArgs e)
        {
            if (!_isPowerOn) return;

            if (CurrentAudioDevice.Id != _initialDefaultDevice.Id)
            {
                _initialDefaultDevice.SetAsDefault();
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
        }
    }
}
