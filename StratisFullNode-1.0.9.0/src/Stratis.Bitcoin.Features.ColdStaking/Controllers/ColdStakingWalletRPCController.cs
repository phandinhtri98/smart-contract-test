using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NBitcoin;
using Stratis.Bitcoin.Consensus;
using Stratis.Bitcoin.Features.BlockStore;
using Stratis.Bitcoin.Features.Wallet;
using Stratis.Bitcoin.Features.Wallet.Interfaces;
using Stratis.Bitcoin.Features.Wallet.Services;
using Stratis.Bitcoin.Interfaces;

namespace Stratis.Bitcoin.Features.ColdStaking.Controllers
{
    /// <summary> All functionality is in WalletRPCController, just inherit the functionality in this feature.</summary>
    [ApiVersion("1")]
    public class ColdStakingWalletRPCController : WalletRPCController
    {
        public ColdStakingWalletRPCController(
            IBlockStore blockStore,
            IBroadcasterManager broadcasterManager,
            ChainIndexer chainIndexer,
            IConsensusManager consensusManager,
            IFullNode fullNode,
            ILoggerFactory loggerFactory,
            Network network,
            IScriptAddressReader scriptAddressReader,
            StoreSettings storeSettings,
            IWalletManager walletManager,
            IWalletService walletService,
            WalletSettings walletSettings,
            IWalletTransactionHandler walletTransactionHandler,
            IWalletSyncManager walletSyncManager) :
            base(blockStore, broadcasterManager, chainIndexer, consensusManager, fullNode, loggerFactory, network, scriptAddressReader, storeSettings, walletManager, walletService, walletSettings, walletTransactionHandler, walletSyncManager)
        {
        }
    }
}
